namespace Smartphone_Shop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public decimal OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }

    }
}
