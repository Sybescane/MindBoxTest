using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox2.Model
{
    public class Category : EntityBase
    {
        public Category()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        public string Name { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
