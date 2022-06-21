using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Models.ViewModel
{
    public class AdminUserCreateViewModel
    {
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public Role Role { get; set; }
    }
}