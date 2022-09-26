using Microsoft.AspNetCore.Http;

namespace Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next.Invoke(httpContext);
            }
            catch (Exception e)
            {
                // Hata yonetimi..
            }
        }
    }
}