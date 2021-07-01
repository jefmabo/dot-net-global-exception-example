using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddleware1(this IApplicationBuilder app)
        {
            app.UseMiddleware<Middleware1>();                
            return app;
        }

        public static IApplicationBuilder UseMiddleware2(this IApplicationBuilder app)
        {
            app.UseMiddleware<Middleware2>();
            return app;
        }

        public static IApplicationBuilder UseMiddleware3(this IApplicationBuilder app)
        {
            app.UseMiddleware<Middleware3>();
            return app;
        }

        public static IApplicationBuilder UseGlobalException(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
            return app;
        }
    }
}
