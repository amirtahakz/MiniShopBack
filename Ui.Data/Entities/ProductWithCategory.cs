using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ui.Data.Entities
{
    public class ProductWithCategory : BaseEntity
    {
        [ForeignKey("CategoryName")]
        public Guid IdCategoryName { get; set; }
        [ForeignKey("Product")]
        public Guid IdProduct { get; set; }
        public Product Product { get; set; }
        public CategoryName CategoryName { get; set; }
    }
}
