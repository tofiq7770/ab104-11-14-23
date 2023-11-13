using Ab104_11_14_2023.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_11_14_2023.DAL
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-SOBUBL4;database=TaskEF;trusted_connection=true;integrated security=true;encrypt=false;");

        }
        public DbSet<Student> Students { get; set; }

    }

}
