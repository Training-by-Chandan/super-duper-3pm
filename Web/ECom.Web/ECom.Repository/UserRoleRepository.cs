using ECom.Web.Data;
using Microsoft.AspNetCore.Identity;

namespace ECom.Repository
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly ApplicationDbContext db;

        public UserRoleRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }

        public (bool, string) Create(IdentityUserRole<string> model)
        {
            try
            {
                db.UserRoles.Add(model);
                db.SaveChanges();
                return (true, "User Role added successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }

    public interface IUserRoleRepository
    {
        (bool, string) Create(IdentityUserRole<string> model);
    }
}