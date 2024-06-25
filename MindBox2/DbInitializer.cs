using Microsoft.EntityFrameworkCore;
using MindBox2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox2
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {

            if (context.Products.Any() || context.Categories.Any())
            {
                return;
            }

            var categories = new List<Category>
            {
                new Category { Name = "Категория 1" },
                new Category { Name = "Категория 2" },
                new Category { Name = "Категория 3" }
            };
            context.Categories.AddRange(categories);
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product { Name = "Продукт 1", Price = 100, ProductCategories = new List<ProductCategory> { new ProductCategory { CategoryId = categories[0].Id } } },
                new Product { Name = "Продукт 2", Price = 200, ProductCategories = new List<ProductCategory> { new ProductCategory { CategoryId = categories[1].Id }, new ProductCategory { CategoryId = categories[2].Id } } },
                new Product { Name = "Продукт 3", Price = 300, ProductCategories = new List<ProductCategory>() }
            };
            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
