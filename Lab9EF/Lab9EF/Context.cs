using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9EF
{
    public class Context : DbContext
    {
        public DbSet<Class> classes { get; set; }
        public DbSet<Student> students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=ENTITY_TEST;Integrated Security=True;TrustServerCertificate=true;");
        }
    }
}
