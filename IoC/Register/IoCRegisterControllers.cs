﻿using Microsoft.Extensions.DependencyInjection;

using System;
using System.Linq;
using System.Reflection;

namespace IoC.Register
{
    internal static class IoCRegisterControllers
    {
        /// <summary>
        /// Obtiene los tipos de una assembly
        /// </summary>
        /// <param name="assembly"></param>
        /// <param name="nameSpace"></param>
        /// <returns></returns>
        internal static Type[] GetTypeInNamespace(Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes()
                .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
                .ToArray();
        }
        /// <summary>
        /// Registra los controladores
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        internal static IServiceCollection RegisterControllers(this IServiceCollection services)
        {
            Type[] Controllers = GetTypeInNamespace(Assembly.Load("UI"), "UI.Controllers");
            Type[] IControllers = GetTypeInNamespace(Assembly.Load("Contratos"), "Contratos.Controllers");


            foreach (Type icontrolador in IControllers)//interfaces icontrolador...
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
