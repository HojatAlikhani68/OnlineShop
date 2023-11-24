using OnlineShop.Shared.Domain.Entities.Base;
using OnlineShop.Shared.Domain.Enumerations.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace OnlineShop.Shared.Domain.Entities.Produncts
{
    public record Product: BaseEntity<int>
    {
        public string Code { get; set; }
        public double Price { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public Discount Discount { get; set; }
        public int Weight { get; set; }
        public ProductWeightUnit ProductWeightUnit { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        
    }

}
