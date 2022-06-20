using ECom.Web.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext db;

        public UserRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }

        public (bool, string) Create(IdentityUser user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return (true, "User created successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public string GetRoleId(string Name)
        {
            return db.Roles.FirstOrDefault(p => p.Name == Name).Id;
        }
    }

    public interface IUserRepository
    {
        (bool, string) Create(IdentityUser user);

        string GetRoleId(string Name);
    }
}