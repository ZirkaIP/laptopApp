using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Models;

namespace OnlineStore.Data
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
        {
            
        }
        public  DbSet<Laptop> Laptop { get; set; }
        public  DbSet<Category> Category { get; set; }
        public  DbSet<ShopCartItem> ShopCartItem { get; set; }
        public  DbSet<Order> Order { get; set; }
        public  DbSet<OrderDetail> OrderDetail { get; set; }
    }
}
