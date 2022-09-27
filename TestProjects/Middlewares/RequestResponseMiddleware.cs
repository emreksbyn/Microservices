using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Text;

namespace Middlewares
{
    public class RequestResponseMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestResponseMiddleware> _logger;

        public RequestResponseMiddleware(RequestDelegate next, ILogger<RequestResponseMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            // Request

            // Orijinal Stream' in yedegini al
            var originalBodyStream = httpContext.Response.Body;

            _logger.LogInformation($"Query Keys : {httpContext.Request.QueryString}");

            MemoryStream requestBody = new MemoryStream();

            await httpContext.Request.Body.CopyToAsync(requestBody);

            requestBody.Seek(0, SeekOrigin.Begin);

            string requestText = await new StreamReader(requestBody).ReadToEndAsync();

            requestBody.Seek(0, SeekOrigin.Begin);


            //string requesText = await new StreamReader(requestBody).ReadToEndAsync();



            MemoryStream tempStream = new MemoryStream();
            httpContext.Response.Body = tempStream;


            await _next.Invoke(httpContext); // Response burada olusur.


            // Response burada alinacak.
            // Fake bir response uretiyoruz.
            httpContext.Response.Body.Seek(0, SeekOrigin.Begin);

            //tempStream.Seek(0, SeekOrigin.Begin);
            //string responseText = await new StreamReader(tempStream, Encoding.UTF8).ReadToEndAsync();

            string responseText = await new StreamReader(httpContext.Response.Body, Encoding.UTF8).ReadToEndAsync();

            //tempStream.Seek(0, SeekOrigin.Begin);

            httpContext.Response.Body.Seek(0, SeekOrigin.Begin);

            await httpContext.Response.Body.CopyToAsync(originalBodyStream);

            _logger.LogInformation($"Request: {requestText}");
            _logger.LogInformation($"Response: {responseText}");
        }
    }
}