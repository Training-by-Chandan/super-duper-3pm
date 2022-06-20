using ECom.Models.ViewModel;
using ECom.Repository;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IUserRoleRepository userRoleRepository;

        public UserService(
            IUserRepository userRepository,
            IUserRoleRepository userRoleRepository
            )
        {
            this.userRepository = userRepository;
            this.userRoleRepository = userRoleRepository;
        }

        public (bool, string) CreateUser(AdminUserViewModel model)
        {
            //we will check if the user exists or not
            var identityUser = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Email,
                Email = model.Email,
                NormalizedEmail = model.Email.ToUpper(),
                NormalizedUserName = model.Email.ToUpper(),
                EmailConfirmed = true,
                LockoutEnabled = false
            };
            var res = userRepository.Create(identityUser);
            if (res.Item1)
            {
                var roleId = userRepository.GetRoleId(model.Role.ToString());

                var userRole = new IdentityUserRole<string>()
                {
                    RoleId = roleId,
                    UserId = identityUser.Id
                };

                return userRoleRepository.Create(userRole);
            }
            return res;
        }
    }

    public interface IUserService
    {
        (bool, string) CreateUser(AdminUserViewModel model);
    }
}