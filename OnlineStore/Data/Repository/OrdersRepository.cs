using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;
using OnlineStore.Data.Interfaces;
using OnlineStore.Data.Models;

namespace OnlineStore.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDbContent appDbContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDbContent _appDbContent, ShopCart _shopCart)
        {
            appDbContent = _appDbContent;
            shopCart = _shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDbContent.Order.Add(order);

            var items = shopCart.ToPayList;
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    LaptopId = el.Laptop.Id,
                    OrderId = order.Id,
                    Price = el.Laptop.Price
                };
                appDbContent.OrderDetail.Add(orderDetail);
            }

            appDbContent.SaveChanges();
        }
    }
}
