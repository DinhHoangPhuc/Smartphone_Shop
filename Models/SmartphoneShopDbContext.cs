using Microsoft.EntityFrameworkCore;

namespace Smartphone_Shop.Models
{
    public class SmartphoneShopDbContext: DbContext
    {
        public SmartphoneShopDbContext(DbContextOptions<SmartphoneShopDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set;}
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
