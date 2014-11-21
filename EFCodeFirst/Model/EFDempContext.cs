using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace EFDemo1.Model
{
    class EFDempContext : DbContext 
    {
        public EFDempContext()
            :base("ConnStrDbDemoEF")
        {

        }

        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}
