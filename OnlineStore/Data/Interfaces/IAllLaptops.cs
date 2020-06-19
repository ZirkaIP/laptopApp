using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Data.Models;

namespace OnlineStore.Data.Interfaces
{
    public interface IAllLaptops
    {
        IEnumerable<Laptop> Laptops { get; }
        IEnumerable<Laptop> GetFavLaptops { get;  }
        Laptop LaptopObj(int lapId);
    }
}
