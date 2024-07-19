using Microsoft.AspNetCore.Mvc;

namespace EmailKitService.CustomFilterActions
{
    public class ApiKeyAttribute : ServiceFilterAttribute
    {
        public ApiKeyAttribute() : base(typeof(ApiKeyAuthFilter))
        {
        }
    }
}
