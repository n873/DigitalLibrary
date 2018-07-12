using DigitalLibrary.Web.Middleware;
using Microsoft.AspNetCore.Builder;

namespace DigitalLibrary.Web.MiddlewareExtensions
{
    public static class SimpleMiddlewareExtensions
    {
        public static IApplicationBuilder UseSimpleMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SimpleMiddleware>();
        }
    }
}
