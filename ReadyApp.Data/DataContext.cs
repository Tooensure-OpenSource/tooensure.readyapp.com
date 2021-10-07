using Microsoft.EntityFrameworkCore;
using ReadyApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Data
{
    internal class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Business> Businesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }

    }
}
