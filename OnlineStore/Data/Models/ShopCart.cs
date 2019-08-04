using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace OnlineStore.Data.Models
{
    public class ShopCart
    {
        private readonly AppDbContent appDbContent;

        public ShopCart(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public string CartId { get; set; }

        public List<ShopCartItem> ToPayList { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);
            return  new ShopCart(context){CartId=shopCartId};
        }

        public void AddToCart(Laptop laptop, int amount)
        {
            appDbContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = CartId,
                Laptop = laptop,
                Price = laptop.Price
            });

            appDbContent.SaveChanges();
        }

        public List<ShopCartItem> GetCartItems()
        {
            return appDbContent.ShopCartItem.Where(c => c.ShopCartId == CartId).Include(s => s.Laptop).ToList();
        }
    }
}
