using ECom.Web.Data;

namespace ECom.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext db;

        public RoleRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }

        public string GetRoleId(string Name)
        {
            return db.Roles.FirstOrDefault(p => p.Name == Name).Id;
        }
    }

    public interface IRoleRepository
    {
        string GetRoleId(string Name);
    }
}