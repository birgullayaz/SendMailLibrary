using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Library.Middlewares
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestResponseLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Capture request
            var originalBodyStream = context.Response.Body;

            try
            {
                // Process request
                await _next(context);
            }
            finally
            {
                // Restore response body
                context.Response.Body = originalBodyStream;
            }
        }
    }
}
