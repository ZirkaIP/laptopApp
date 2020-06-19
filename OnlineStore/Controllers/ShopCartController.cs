using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Data.Interfaces;
using OnlineStore.Data.Models;
using OnlineStore.Data.Repository;
using OnlineStore.ViewModels;

namespace OnlineStore.Controllers
{
    public class ShopCartController : Controller
    {
        private IAllLaptops _laptopRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllLaptops laptopRep, ShopCart shopCart)
        {
            _laptopRep = laptopRep;
            _shopCart = shopCart;
        }

        public ViewResult index()
        {
            var items = _shopCart.GetCartItems();
            _shopCart.ToPayList = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _laptopRep.Laptops.FirstOrDefault(i => i.Id==id);
            if (item != null)
            {
                _shopCart.AddToCart(item, 1);
            }

            return RedirectToAction("index");
        }
    }
}
