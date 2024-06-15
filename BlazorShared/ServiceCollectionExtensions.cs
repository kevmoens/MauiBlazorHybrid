using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShared
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBlazorShared(this IServiceCollection services)
        {
            services.AddScoped<ExampleJsInterop>();
        }
    }
}
