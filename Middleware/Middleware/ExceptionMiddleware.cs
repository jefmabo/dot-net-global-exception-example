using Api.Middleware.Exceptions;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Api.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (ExceptionTemplate ex)
            {
                await TratarExcecaoGlobalAsync(ex, httpContext);
            }
            catch (Exception ex)
            {
                await TratarExcecaoGenericaAsync(ex, httpContext);
            }
        }

        private async Task TratarExcecaoGlobalAsync(ExceptionTemplate ex, HttpContext httpContext)
        {
            httpContext.Response.StatusCode = ex.HttpResponse;
            await httpContext.Response.WriteAsync("{messagem: " + ex.Message + "}");
        }

        private async Task TratarExcecaoGenericaAsync(Exception ex, HttpContext httpContext)
        {
            httpContext.Response.StatusCode = 500;
            await httpContext.Response.WriteAsync("{messagem: " + ex.Message + "}");
        }
    }
}
