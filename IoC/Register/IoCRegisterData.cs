using Contratos.Repositories;

using Infraestructura.UoW;

using Microsoft.Extensions.DependencyInjection;

namespace IoC.Register
{
    internal static class IoCRegisterData
    {
        /// <summary>
        /// Registra el repositorio
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        internal static IServiceCollection RegisterUnitOfWork(this IServiceCollection services)
        {
            return services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
