using OnlineShop.Shared.Domain.Entities.Base;

namespace OnlineShop.Shared.Domain.Entities.Produncts
{
    public record Discount:BaseEntity<int>
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public byte Persentage { get; set; }
    }
}