using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Data.Models;

namespace OnlineStore.ViewModels
{
    public class LaptopListViewModels
    {
        public IEnumerable<Laptop> AllLaptops { get; set; }

        public string currCategory { get; set; }
    }
}
