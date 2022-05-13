using AutoMapper;

using Infraestructura;

using IoC;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using SL.Services.Mapper;

using System;
using System.IO;
using System.Windows.Forms;

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
            var mainForm = services.GetRequiredService<LoginForm>();
            Application.Run(mainForm);

        }


        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContext>(options =>
            options.UseSqlServer(GetConnectionString()).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            services.AddSingleton<LoginForm>();

            services.AddAutoMapper(typeof(LoginForm));
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperHelper());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);


            services.ConfigureIoC(Configuration);

        }

        private static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json");

            Configuration = builder.Build();
            var connectionString = Configuration.GetConnectionString("SqlConnection");
            return connectionString;
        }
    }
}
