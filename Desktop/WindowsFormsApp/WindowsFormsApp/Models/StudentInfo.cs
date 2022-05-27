using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Models
{
    public class StudentInfo
    {
        public StudentInfo()
        {
        }

        public StudentInfo(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public StudentInfo(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Email { get; set; }
    }
}