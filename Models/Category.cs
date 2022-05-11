using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDB.Models
{
    public class Category
    {
        public Category()
        {
            this.Products = new HashSet<CategoriesProducts>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<CategoriesProducts> Products { get; set; }
    }
}
