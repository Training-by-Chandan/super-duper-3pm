using System;
using System.Collections.Generic;

namespace ConsoleApp.EF.Models
{
    public partial class StudentParent
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? ParentId { get; set; }
    }
}
