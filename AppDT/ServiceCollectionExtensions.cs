﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDT
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAppDT(this IServiceCollection services)
        {
            services.AddScoped<ExampleDTJsInterop>();
        }
    }
}
