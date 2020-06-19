using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Data.Models;

namespace OnlineStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Laptop> FavLaptops { get; set; }
    }
}
