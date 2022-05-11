using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDB.Models
{
    public class CategoriesProducts
    {
        [ForeignKey("CategoryID")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        [ForeignKey("ProductID")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
