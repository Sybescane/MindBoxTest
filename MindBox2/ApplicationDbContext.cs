using Microsoft.EntityFrameworkCore;
using MindBox2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox2
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        public ApplicationDbContext() 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local);Database=mindbox;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasOne(e => e.Product)
                .WithMany(e => e.ProductCategories);

            modelBuilder.Entity<ProductCategory>()
                .HasOne(e => e.Category)
                .WithMany(e => e.ProductCategories);

            modelBuilder.Entity<ProductCategory>()
                .HasKey(e => new { e.ProductId, e.CategoryId });
        }
    }
}
