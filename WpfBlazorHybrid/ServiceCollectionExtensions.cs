using HybridCoupling.Native.App;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfBlazorHybrid.Coupling.App;

namespace WpfBlazorHybrid
{
    public static class ServiceCollectionExtensions
    {
        public static void AddNative(this IServiceCollection services)
        {
            services.AddTransient<IMessageBox, WpfMessageBox>();
        }
    }
}
