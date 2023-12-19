using GoogleTranslateDemo.ModelHelpers;

namespace GoogleTranslateDemo
{
    public static class SignUpService
    {
        public static IServiceCollection WebbAppSignUpService(this IServiceCollection services)
        {
            services.AddSingleton<GoogleTranslationHelper>();
            return services;
        }
    }
}
