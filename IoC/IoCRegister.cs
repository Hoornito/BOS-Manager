using IoC.Register;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class IoCRegister
    {
        public static IServiceCollection ConfigureIoC(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterControllers();
            services.RegisterDataLayer(configuration);
            services.RegisterUnitOfWork();
            services.RegisterBusinessLayer();
            return services;
        }
    }
}
