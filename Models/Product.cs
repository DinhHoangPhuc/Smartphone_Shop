namespace Smartphone_Shop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool IsLatestProduct { get; set; }
        public bool IsTrendingProduct { get; set; }
        public bool IsSpecialProduct { get; set; }
        public int Guarantee { get; set; }
        public int CategoryId { get; set; }
        public int? DiscountId { get; set; }
        public int VendorId { get; set; }
        public Category Category { get; set; } = default!;
        public Discount? Discount { get; set; }
        public Vendor Vendor { get; set; }= default!;
    }
}
