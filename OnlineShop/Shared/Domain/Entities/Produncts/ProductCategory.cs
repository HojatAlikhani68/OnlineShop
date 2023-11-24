using OnlineShop.Shared.Domain.Entities.Base;

#nullable disable
namespace OnlineShop.Shared.Domain.Entities.Produncts
{
    public record ProductCategory:BaseEntity<int>
    {
        public string Description { get; set; }
        public int ParentId { get; set; }
        public Discount Discount { get; set; }

    }
}