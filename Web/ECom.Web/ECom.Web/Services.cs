using ECom.Repository;
using ECom.Services;

namespace ECom.Web
{
    public class Services
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Repository

            services.AddTransient<ICategoryRepository, CategoryRepository>();

            #endregion Repository

            #region Services

            services.AddTransient<ICategoryService, CategoryService>();

            #endregion Services
        }
    }
}