using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using SL.IoC.Register;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.IoC
{
    public static class IoCRegister
    {
        public static IServiceCollection ConfigureIoCSL(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterControllers();
            services.RegisterDataLayer(configuration);
            services.RegisterUnitOfWork();
            services.RegisterBusinessLayer();
            return services;
        }
    }
}
