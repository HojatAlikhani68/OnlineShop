using OnlineShop.Shared.Domain.Entities.Base;

namespace OnlineShop.Shared.Domain.Entities.Customers
{
    public record Address:BaseEntity<int>
    {
        private const string Seperator = " , ";
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Alley { get; set; }
        public string Nubmer { get; set; }
        public short Unit { get; set; }
        public string PostalCode { get; set; }
        public string FullAddress => string
            .Concat(State, Seperator,
                     City, Seperator,
                     Street, Seperator,
                     Alley, Seperator,
                     Nubmer, Seperator,
                     Unit, Seperator,
                     PostalCode);

    }
}