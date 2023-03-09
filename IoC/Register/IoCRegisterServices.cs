using BLL.Services;

using Contratos.Services;

using Microsoft.Extensions.DependencyInjection;

using SL.Services.Extensions;

using System.Linq;

namespace IoC.Register
{
    internal static class IoCRegisterService
    {
        /// <summary>
        /// Registra el servicio
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        internal static IServiceCollection RegisterBusinessLayer(this IServiceCollection services)
        {
            var genericType = typeof(IGenericService<>).GetGenericTypeDefinition();
            var iServicesTypes = typeof(IGenericService<>).Assembly.GetTypes(t => t.IsInterface && t.ImplementsGenericInterface(genericType));

            services = iServicesTypes.Aggregate(services, (service, iServiceType) =>
            {
                var serviceType = typeof(GenericService<>).Assembly.FindType(t => t.IsClass && iServiceType.IsAssignableFrom(t));
                if (serviceType != null)
                {
                    service.AddTransient(iServiceType, serviceType);
                }
                return service;
            });

            return services;
        }
    }
}
