using System;
using System.Collections.Generic;

namespace ConsoleApp.EF.Models
{
    public partial class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
    }
}
