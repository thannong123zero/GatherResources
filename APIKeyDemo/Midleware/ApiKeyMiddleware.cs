using APIKeyDemo.CustomFilterActions;
using APIKeyDemo.Models;
using System.Net;

namespace APIKeyDemo.Midleware
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IApiKeyValidation _apiKeyValidation;
        public ApiKeyMiddleware(RequestDelegate next, IApiKeyValidation apiKeyValidation)
        {
            _next = next;
            _apiKeyValidation = apiKeyValidation;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (string.IsNullOrWhiteSpace(context.Request.Headers[Constants.ApiKeyHeaderName]))
            {
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return;
            }
            string? userApiKey = context.Request.Headers[Constants.ApiKeyHeaderName];
            if (!_apiKeyValidation.IsValidApiKey(userApiKey!))
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                return;
            }
            await _next(context);
        }
    }
}
