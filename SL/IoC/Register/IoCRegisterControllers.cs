using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SL.IoC.Register
{
    internal static class IoCRegisterControllers
    {
        internal static Type[] GetTypeInNamespace(Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes()
                .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
                .ToArray();
        }

        internal static IServiceCollection RegisterControllers(this IServiceCollection services)
        {
            Type[] Controllers = GetTypeInNamespace(Assembly.Load("UI"), "UI.Controllers");
            Type[] IControllers = GetTypeInNamespace(Assembly.Load("Contratos"), "Contratos.Controllers");


            foreach (Type icontrolador in IControllers)
            {
                var controller = Controllers.Where(x => x.IsAssignableTo(icontrolador) && icontrolador.IsInterface).FirstOrDefault();
                if (controller != null)
                {
                    services.AddTransient(icontrolador, controller);
                }
            }

            return services;
        }
    }
}
