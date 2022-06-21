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
    }

    public interface IUserRepository
    {
        (bool, string) Create(IdentityUser user);
    }
}