using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ui.Data.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string PriceOffer { get; set; }
        public string ImageProduct { get; set; }
        public int NumbersOfProduct { get; set; }
        public List<ProductWithCategory> ProductWithCategorys { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
