using Bankos.Services.Response;
using Newtonsoft.Json;
using System.Text;

namespace Bankos.API.Middleware.GlobalErrorHandler
{
    public class GlobalErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public GlobalErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                var response = new BaseResponseModel();
                response.GenerateFailure(ex.Message);
                context.Response.StatusCode = 400;
                context.Response.ContentType = "application/json";
                string jsonString = JsonConvert.SerializeObject(response);

                await context.Response.WriteAsync(jsonString, Encoding.UTF8);

                return;
            }
        }
    }

    public static class GlobalErrorHandlerMiddlewareExtensions
    {
        public static IApplicationBuilder UseGlobalErrorHandler(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GlobalErrorHandlerMiddleware>();
        }
    }
}
