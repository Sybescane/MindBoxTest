using Microsoft.EntityFrameworkCore;
using MindBox2.Model;

namespace MindBox2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {                
                DbInitializer.Initialize(context);

                var products = context.Products
                         .Include(p => p.ProductCategories)
                         .ThenInclude(pc => pc.Category)
                         .ToList();

                foreach (var product in products)
                {
                    Console.WriteLine($"Продукт: {product.Name}, Цена: {product.Price}");

                    foreach (var productCategory in product.ProductCategories)
                    {
                        Console.WriteLine($" - Категория: {productCategory.Category.Name}");
                    }
                }
            }
        }
    }
}
