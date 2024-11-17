using Lipstick._Convergence.BusinessLogic.Helpers;
using Lipstick._Convergence.BusinessLogic.IHelpers;
using Lipstick._Convergence.DataAccess;

namespace Lipstick._Convergence.Services
{
    public static class SignUpService
    {
        public static IServiceCollection SignUp(this IServiceCollection services)
        {
            services.AddScoped<DatabaseContext>();
            services.AddScoped<IUnitOfWork,UnitOfWork>();
            services.AddScoped<IArticleHelper,ArticleHelper>();
            services.AddScoped<IBrandHelper,BrandHelper>();
            //services.AddScoped<ILayoutHelper,LayoutHelper>();
            services.AddScoped<ICategoryHelper,CategoryHelper>();
            services.AddScoped<ISubCategoryHelper, SubCategoryHelper>();
            services.AddScoped<IProductHelper, ProductHelper>();
            services.AddScoped<ITopicHelper, TopicHelper>();
            services.AddScoped<IUnitHelper, UnitHelper>();


            return services;
        }
    }
}
