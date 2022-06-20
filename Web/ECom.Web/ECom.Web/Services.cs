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
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserRoleRepository, UserRoleRepository>();

            #endregion Repository

            #region Services

            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IUserService, UserService>();

            #endregion Services
        }
    }
}