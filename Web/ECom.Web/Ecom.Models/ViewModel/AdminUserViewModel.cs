using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Models.ViewModel
{
    public class AdminUserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
        User = 0,
        Employee = 1,
        Admin = 2
    }
}