using Contratos.Repositories;

using Infraestructura;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using SL.Services.Extensions;

using System.Linq;

namespace IoC.Register
{
    internal static class IoCRegisterRepository
    {
        /// <summary>
        /// Registra el repositorio
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        internal static IServiceCollection RegisterDataLayer(this IServiceCollection services, IConfiguration configuration)
        {
            var genericType = typeof(IGenericRepository<>).GetGenericTypeDefinition();
            var iRepositories = typeof(IGenericRepository<>).Assembly.GetTypes(t => t.IsInterface && t.ImplementsGenericInterface(genericType));

            services = iRepositories?.Aggregate(services, (service, iRepository) =>
            {
                var repository = typeof(AppDBContext).Assembly.FindType(t => t.IsClass && iRepository.IsAssignableFrom(t));
                if (repository != null)
                {
                    service.AddTransient(iRepository, repository);
                }
                return service;
            });
            //services.AddTransient<IDataRepository>(s => new DataRepository(configuration.GetConnectionString("SqlConnection")));

            return services;
        }
    }

}
