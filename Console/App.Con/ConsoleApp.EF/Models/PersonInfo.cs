using System;
using System.Collections.Generic;

namespace ConsoleApp.EF.Models
{
    public partial class PersonInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public int? Age { get; set; }
        public decimal? Salary { get; set; }
    }
}
