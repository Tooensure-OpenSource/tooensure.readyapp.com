using Microsoft.EntityFrameworkCore;
using ReadyApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Business>? Businesses { get; set; }
        public DbSet<ProductItem>? ProductItems { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<OrderItem>? OrderItems { get; set; }
        public DbSet<Order>? Orders { get; set; }


    }
}
