﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using OnlineStore.Data.Interfaces;
using OnlineStore.Data.Models;
using OnlineStore.ViewModels;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using ViewResult = Microsoft.AspNetCore.Mvc.ViewResult;

namespace OnlineStore.Controllers
{
    [RoutePrefix("laptops")]
    public class LaptopsController : Controller
    {
        private readonly IAllLaptops allLaptops;
        private readonly ILaptopsCategory laptopsCategory;

        public LaptopsController(IAllLaptops iAllLaptops, ILaptopsCategory iLaptopsCategory)
        {
            allLaptops = iAllLaptops;
            laptopsCategory = iLaptopsCategory;
        }

        [Microsoft.AspNetCore.Mvc.Route("list")]
        [Microsoft.AspNetCore.Mvc.Route("list/{category}")]

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Laptop> laptops = null;
            string currCategory = String.Empty;
            string LaptopCategory;
            if (string.IsNullOrEmpty(category))
            {
                laptops = allLaptops.Laptops.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("xiaomi", category, StringComparison.OrdinalIgnoreCase))
                {
                    laptops = allLaptops.Laptops.Where(i => i.Category.CategoryName.Equals("Xiaomi")).OrderBy(i=> i.Price);
                }
                else
                
                 if (string.Equals("apple", category, StringComparison.OrdinalIgnoreCase))
                {
                    laptops = allLaptops.Laptops.Where(i => i.Category.CategoryName.Equals("Apple")).OrderBy(i => i.Price);
                }
                else if (string.Equals("asus", category, StringComparison.OrdinalIgnoreCase))
                {
                    laptops = allLaptops.Laptops.Where(i => i.Category.CategoryName.Equals("Asus")).OrderBy(i => i.Price);
                }
                else if (string.Equals("dell", category, StringComparison.OrdinalIgnoreCase))
                {
                    laptops = allLaptops.Laptops.Where(i => i.Category.CategoryName.Equals("Dell")).OrderBy(i => i.Price);
                }
                else if (string.Equals("lenovo", category, StringComparison.OrdinalIgnoreCase))
                {
                    laptops = allLaptops.Laptops.Where(i => i.Category.CategoryName.Equals("Lenovo")).OrderBy(i => i.Price);
                }
                currCategory = _category;
            }

            var lapObj = new LaptopListViewModels
            {
                AllLaptops = laptops,
                currCategory = currCategory
            };

            ViewBag.Title = "Laptops page";
           
            return View(lapObj);
        }
    }
}
