using AutoMapper;

using Infraestructura;

using IoC;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using SL.IoC;
using SL.Services.Mapper;

using System;
using System.IO;
using System.Windows.Forms;

using UI.ChildForms;

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
            var mainForm = services.GetRequiredService<PatenteFamiliaForm>();
            //var mainForm = services.GetRequiredService<LoginForm>();
            Application.Run(mainForm);

        }


        public static void ConfigureServices(IServiceCollection services)
        {
            ConfigurationBuild();
            services.AddDbContext<SL.InfraSL.AppDBContext>(options =>
            options.UseSqlServer(GetSLConnString()).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            services.AddDbContext<AppDBContext>(options =>
            options.UseSqlServer(GetConnectionString()).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            //services.AddSingleton<LoginForm>();
            services.AddSingleton<PatenteFamiliaForm>();
            
            //services.AddAutoMapper(typeof(LoginForm));
            services.AddAutoMapper(typeof(PatenteFamiliaForm));
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
    }
}
