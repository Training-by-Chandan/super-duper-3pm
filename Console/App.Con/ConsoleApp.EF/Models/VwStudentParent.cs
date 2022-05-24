using System;
using System.Collections.Generic;

namespace ConsoleApp.EF.Models
{
    public partial class VwStudentParent
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
    }
}
