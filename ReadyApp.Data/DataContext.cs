using Microsoft.EntityFrameworkCore;
using ReadyApp.Domain;
using ReadyApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<ProductItem>? ProductItems { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<OrderItem>? OrderItems { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Owner>? Owners { get; set; }
        public DbSet<Employee>? Employees { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-EMFSR5P\\TOOENSURE;Initial Catalog=TheReadyAppDb;Integrated Security=True");
        //}
    }
}
