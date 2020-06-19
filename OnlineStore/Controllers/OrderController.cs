using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Data;
using OnlineStore.Data.Interfaces;
using OnlineStore.Data.Models;

namespace OnlineStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders _allOrders, ShopCart _shopCart)
        {
            allOrders = _allOrders;
            shopCart = _shopCart;
        }

        public IActionResult CheckOut()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckOut(Order order)
        {
            shopCart.ToPayList = shopCart.GetCartItems();
            if (shopCart.ToPayList.Count == 0)
            {
                ModelState.AddModelError("","No items in the cart");
            }

            if (ModelState.IsValid)
            {
                allOrders.CreateOrder(order);
                return RedirectToAction("Complete");

            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Order successfully registered";
            return View();
        }
    }
}
