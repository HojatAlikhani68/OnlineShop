using OnlineShop.Shared.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Shared.Domain.Entities.Customers
{
    public record Customer:BaseEntity<int>
    {
        public string Name { get; set; }
        public string NationalCode { get; set; }
        public string Mobile { get; set; }
        public Address Address { get; set; }
        public CustomerType CustomerType { get; set; }

    }
}
