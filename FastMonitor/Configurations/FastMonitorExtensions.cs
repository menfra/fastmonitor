using FastMonitor.Logic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastMonitor.Configurations
{
    public static class FastMonitorExtensions
    {
        public static IServiceCollection AddFastMonitor(this IServiceCollection services, Action<FastMonitorOptions> configureOptions)
        {
            var options = new FastMonitorOptions();
            configureOptions(options);
            services.AddSingleton(options);
            services.AddScoped<IFastMonitor, FastMonitorService>();
            return services;
        }
    }
}
