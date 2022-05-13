using Contratos.Repositories;

using Infraestructura.UoW;

using Microsoft.Extensions.DependencyInjection;

namespace IoC.Register
{
    internal static class IoCRegisterData
    {
        internal static IServiceCollection RegisterUnitOfWork(this IServiceCollection services)
        {
            return services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
