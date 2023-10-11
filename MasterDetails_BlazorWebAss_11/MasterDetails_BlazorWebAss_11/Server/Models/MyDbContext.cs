using MasterDetails_BlazorWebAss_11.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MasterDetails_BlazorWebAss_11.Server.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>()
                .HasData(
                new Product { ProductId = 1, ProductName = "Mango-R1" },
                new Product { ProductId = 2, ProductName = "Fruit-P1" },
                new Product { ProductId = 3, ProductName = "Vagitable-N1" }
                );
        }
    }

}
