using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Data
{
    public class DefaultDbContext : DbContext
    {
        public DbSet<StudentInfo> StudentInfos { get; set; }

        public DefaultDbContext() : base("name=Default")
        {
        }
    }
}