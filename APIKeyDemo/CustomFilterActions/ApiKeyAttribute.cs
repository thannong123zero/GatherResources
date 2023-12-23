using Microsoft.AspNetCore.Mvc;

namespace APIKeyDemo.CustomFilterActions
{
    public class ApiKeyAttribute : ServiceFilterAttribute
    {
        public ApiKeyAttribute() : base(typeof(ApiKeyAuthFilter))
        {
        }
    }
}
