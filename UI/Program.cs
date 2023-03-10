using AutoMapper;

using Infraestructura;

using IoC;

using log4net.Appender;
using log4net;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using SL.Contratos.Repositories;
using SL.Domain.Models;
using SL.IoC;
using SL.Services.Mapper;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

using UI.ChildForms;
using UI.ChildForms.Composite;
using log4net.Layout;
using log4net.Repository.Hierarchy;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace UI
{
    static class Program
    {
        public static IConfiguration Configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitializeLogger();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    ConfigureServices(services);
                })
                .Build();

            var services = host.Services;
            UpdateDatabases(services);
            VerifyBusinessTables(services);
            //var mainForm = services.GetRequiredService<AdministracionForm>();
            var mainForm = services.GetRequiredService<LoginForm>();
            Application.Run(mainForm);

        }


        public static void ConfigureServices(IServiceCollection services)
        {
            ConfigurationBuild();
            services.AddDbContext<SL.InfraSL.AppDBContext>(options =>
            options.UseSqlServer(GetSLConnString()));
            services.AddDbContext<AppDBContext>(options =>
            options.UseSqlServer(GetConnectionString()).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            services.AddSingleton<LoginForm>();
            //services.AddSingleton<AdministracionForm>();

            services.AddAutoMapper(typeof(LoginForm));
            //services.AddAutoMapper(typeof(AdministracionForm));
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperHelper());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);


            services.ConfigureIoC(Configuration);
            services.ConfigureIoCSL(Configuration);

        }


        private static void ConfigurationBuild()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
        }

        private static string GetConnectionString()
        {
            var connectionString = Configuration.GetConnectionString("SqlConnection");
            return connectionString;
        }
        private static string GetSLConnString()
        {
            var connectionString = Configuration.GetConnectionString("ServiceLayerSqlConnection");
            return connectionString;
        }

        private static void UpdateDatabases(IServiceProvider services)
        {
            var dbContext = services.GetRequiredService<AppDBContext>();
            var SldbContext = services.GetRequiredService<SL.InfraSL.AppDBContext>();
            if (!dbContext.Database.CanConnect())
                dbContext.Database.Migrate();

            if (!SldbContext.Database.CanConnect())
                SldbContext.Database.Migrate();
        }

        private static void VerifyBusinessTables(IServiceProvider services)
        {
            var dbContext = services.GetRequiredService<AppDBContext>();
            var SldbContext = services.GetRequiredService<SL.InfraSL.AppDBContext>();
            var usuarioRepository = services.GetRequiredService<IUsuariosRepository>();
            var permisoRepository = services.GetRequiredService<IPermisosRepository>();
            var usuario_PermisoRepository = services.GetRequiredService<IUsuario_PermisoRepository>();

            UsuarioModel usuario = new();
            PermisoModel permisoModel = new();
            if (!usuarioRepository.Get(x => x.usuario.ToLower() == "admin").Any())
            {
                usuario.nombre = "admin";
                usuario.usuario = "admin";
                usuario.pw = HashPassword("admin");
                usuario.email = "admin@admin.com";
                usuario.idioma = "es-ES";
                usuario.apellido = "admin";
                usuarioRepository.Insert(usuario);
                SldbContext.SaveChanges();
            }
            else
                usuario = usuarioRepository.Get(x => x.usuario == "admin").FirstOrDefault();

            if (!permisoRepository.Get(x => x.permiso == "Administrador").Any())
            {
                permisoModel.nombre = "Admin";
                permisoModel.permiso = "Administrador";
                permisoRepository.Insert(permisoModel);
                SldbContext.SaveChanges();
            }
            else
                permisoModel = permisoRepository.Get(x => x.permiso == "Administrador").FirstOrDefault();

            if (!usuario_PermisoRepository.Get(x => x.id_permiso == permisoModel.id && x.id_usuario == usuario.id_usuario).Any())
            {
                Usuario_PermisoModel usuario_PermisoModel = new();
                usuario_PermisoModel.id_usuario = usuario.id_usuario;
                usuario_PermisoModel.id_permiso = permisoModel.id;
                usuario_PermisoRepository.Insert(usuario_PermisoModel);
            }

            SldbContext.SaveChanges();
        }

        private static string HashPassword(string password)
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            byte[] hash = new Rfc2898DeriveBytes(password, salt, 10000).GetBytes(32);

            byte[] hashBytes = new byte[48];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 32);

            return Convert.ToBase64String(hashBytes);
        }

        private static void InitializeLogger()
        {
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();

            PatternLayout patternLayout = new PatternLayout();
            patternLayout.ConversionPattern = "%date [%thread] %-5level %logger [%ndc] %line - %message%newline";
            patternLayout.ActivateOptions();

            RollingFileAppender roller = new RollingFileAppender();
            roller.Name = "LoggerManager";
            roller.AppendToFile = false;
            roller.File = AppDomain.CurrentDomain.BaseDirectory + "\\LoggerManager.txt";
            roller.Layout = patternLayout;
            roller.MaxSizeRollBackups = 5;
            roller.MaximumFileSize = "10MB";
            roller.RollingStyle = RollingFileAppender.RollingMode.Size;
            roller.StaticLogFileName = true;
            roller.LockingModel = new FileAppender.MinimalLock();
            roller.ActivateOptions();
            hierarchy.Root.AddAppender(roller);

            MemoryAppender memory = new MemoryAppender();
            memory.ActivateOptions();
            hierarchy.Root.AddAppender(memory);

            //hierarchy.Root.Level = Level.Info;
            hierarchy.Configured = true;
        }
    }
}
