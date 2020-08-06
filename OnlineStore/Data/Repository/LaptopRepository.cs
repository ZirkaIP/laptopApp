using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Data.Interfaces;
using OnlineStore.Data.Models;

namespace OnlineStore.Data.Repository
{
    public class LaptopRepository : IAllLaptops
    {
        private readonly AppDbContent appDbContent;

        public LaptopRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Laptop> Laptops => appDbContent.Laptop.Include(c => c.Category);

        public IEnumerable<Laptop> GetFavLaptops =>
            appDbContent.Laptop.Where(c => c.IsFavorite == true).Include(c => c.Category);

        public Laptop LaptopObj(int lapId) => appDbContent.Laptop.FirstOrDefault(p => p.Id == lapId);


    }
}
