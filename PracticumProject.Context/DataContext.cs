using Microsoft.EntityFrameworkCore;
using PracticumProject.Repositories.Entities;
using PracticumProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Context
{
    public class DataContext : DbContext, IContext
    {
        public DbSet<User> Users { get ; set ; }
        public DbSet<Child> Children { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PracticumProjRutiCohen;Trusted_Connection=True");
           // optionsBuilder.UseSqlServer("Server=DESKTOP-24EQMFH;Database=RutiPracticum;Trusted_Connection=True;");

        }
    }
}
