using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using OnlineStore.Data.Interfaces;
using OnlineStore.Data.Models;
using OnlineStore.ViewModels;

namespace OnlineStore.Controllers
{
    public class HomeController : Controller
    {
        private IAllLaptops _laptopRep;
        
        public HomeController(IAllLaptops laptopRep)
        {
            _laptopRep = laptopRep;
        }

        [HttpGet]
        public ViewResult Index()
        {
            var homeLaptops = new HomeViewModel
            {
                FavLaptops = _laptopRep.GetFavLaptops
            };
            return View(homeLaptops);
        }
    }
}
