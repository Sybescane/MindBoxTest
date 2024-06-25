using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox2.Model
{
    public class Product : EntityBase
    {
        public Product()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }
        
        public string Name { get; set; }

        public int Price { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
