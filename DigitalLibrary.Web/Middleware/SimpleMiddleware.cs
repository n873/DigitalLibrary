using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace DigitalLibrary.Web.Middleware
{
    public class SimpleMiddleware
    {
        private readonly RequestDelegate Next;

        public SimpleMiddleware(RequestDelegate next)
        {
            Next = next;
        }

        public Task InvokeAsync(HttpContext context)
        {
            return this.Next(context);
        }
    }
}
