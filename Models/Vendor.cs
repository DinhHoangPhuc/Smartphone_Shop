namespace Smartphone_Shop.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Product>? Products { get; set; }
    }
}
