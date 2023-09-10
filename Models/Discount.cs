namespace Smartphone_Shop.Models
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public decimal Percent { get; set; }
        public List<Product>? Products { get; set; }
    }
}
