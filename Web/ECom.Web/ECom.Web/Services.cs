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
            services.AddTransient<IProductRepository, ProductRepository>();

            #endregion Repository

            #region Services

            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductService, ProductService>();

            #endregion Services
        }
    }
}