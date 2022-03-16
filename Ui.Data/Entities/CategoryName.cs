using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ui.Data.Entities
{
    public class CategoryName : BaseEntity
    {
        public string Subject { get; set; }
        public List<ProductWithCategory> ProductWithCategorys { get; set; }
    }
}
