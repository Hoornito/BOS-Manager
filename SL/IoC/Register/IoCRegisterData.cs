using Microsoft.Extensions.DependencyInjection;

using SL.Contratos;
using SL.InfraSL.UoW;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.IoC.Register
{
    internal static class IoCRegisterData
    {
        internal static IServiceCollection RegisterUnitOfWork(this IServiceCollection services)
        {
            return services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
