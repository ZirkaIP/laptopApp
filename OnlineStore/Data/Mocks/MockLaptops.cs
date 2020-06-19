using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using OnlineStore.Data.Interfaces;
using OnlineStore.Data.Models;

namespace OnlineStore.Data.Mocks
{
    public class MockLaptops : IAllLaptops
    {
        private  readonly ILaptopsCategory _laptopsCategory = new MockCategory();

        public IEnumerable<Laptop> Laptops
        {
            get
            {
                return new List<Laptop>
                {
                    new Laptop
                    {
                        Name = "Xiaomi Mi Gaming Laptop",
                        ShortDesc = "Gamers will be impressed",
                        LongDesc = "",
                        Img ="/png/Xiaomi Mi Gaming Laptop.jpeg",
                        Price = 1500,
                        IsFavorite = false,
                        IsAvailable = true,
                        Category =_laptopsCategory.AllCategories.ElementAt(0)
                    },

                    new Laptop
                    {
                        Name = "Xiaomi Mi Notebook 15.6 (steel,2017)",
                        ShortDesc = "Perfect style, size and hardware",
                        LongDesc = "",
                        Img ="/png/xiaomi mi notebook 15_6.jpg",
                        Price = 800,
                        IsFavorite = true,
                        IsAvailable = true,
                        Category =_laptopsCategory.AllCategories.ElementAt(0)
                    },

                    new Laptop
                    {
                        Name = "Xiaomi Mi Notebook Air 13.3 ",
                        ShortDesc = "As comfortable as you need",
                        LongDesc = "",
                        Img ="/png/Xiaomi mi notebook air 13_3.jpg",
                        Price = 900,
                        IsFavorite = false,
                        IsAvailable = true,
                        Category =_laptopsCategory.AllCategories.ElementAt(0)
                    },

                    new Laptop
                    {
                        Name = "Apple MacBook Pro 15 inch Touch Bar (2018)",
                        ShortDesc = "So good",
                        LongDesc = "",
                        Img ="/png/Apple MacBook Pro 15 Touch Bar (2018 год).jpg",
                        Price = 2500,
                        IsFavorite = true,
                        IsAvailable = true,
                        Category =_laptopsCategory.AllCategories.ElementAt(1)
                    },

                    new Laptop
                    {
                        Name = "Apple MacBook (2017)",
                        ShortDesc = "Nice size - top hardware",
                        LongDesc = "",
                        Img ="/png/Apple MacBook Pro 15 Touch Bar (2018 год).jpg",
                        Price = 1800,
                        IsFavorite = false,
                        IsAvailable = true,
                        Category =_laptopsCategory.AllCategories.ElementAt(1)
                    },

                    new Laptop
                    {
                        Name = "Apple MacBook Air 13 inch (2017)",
                        ShortDesc = "Looks like a kid, but powerful inside",
                        LongDesc = "",
                        Img ="/png/Apple MacBook Pro 13 (2017).jpeg",
                        Price = 950,
                        IsFavorite = false,
                        IsAvailable = true,
                        Category =_laptopsCategory.AllCategories.ElementAt(1)
                    },

                    new Laptop
                    {
                        Name = "ASUS VivoBook S15 S530UF-BQ077T",
                        ShortDesc = "Good hardware for good price",
                        LongDesc = "",
                        Img ="/png/ASUS VivoBook S15.jpg",
                        Price = 700,
                        IsFavorite = false,
                        IsAvailable = true,
                        Category =_laptopsCategory.AllCategories.ElementAt(2)
                    },

                    new Laptop
                    {
                        Name = "ASUS Zenbook UX333FA-A3071T",
                        ShortDesc = "Style and power",
                        LongDesc = "",
                        Img ="/png/ASUS Zenbook UX333FA-A3071T.jpg",
                        Price = 1100,
                        IsFavorite = true,
                        IsAvailable = true,
                        Category =_laptopsCategory.AllCategories.ElementAt(2)
                    },

                    new Laptop
                    {
                        Name = "ASUS X507MA-EJ113",
                        ShortDesc = "Comfortable home laptop",
                        LongDesc = "",
                        Img ="/png/ASUS X507MA-EJ113.jpeg",
                        Price = 1100,
                        IsFavorite = false,
                        IsAvailable = true,
                        Category =_laptopsCategory.AllCategories.ElementAt(2)
                    },

                    new Laptop
                    {
                        Name = "Dell G3 15 ",
                        ShortDesc = "For work and games",
                        LongDesc = "",
                        Img ="/png/Dell G3 15 .jpeg",
                        Price = 1150,
                        IsFavorite = false,
                        IsAvailable = true,
                        Category =_laptopsCategory.AllCategories.ElementAt(3)
                    },

                    new Laptop
                    {
                        Name = "Dell XPS 15",
                        ShortDesc = "Elite laptop",
                        LongDesc = "",
                        Img ="/png/Dell XPS 15.jpg",
                        Price = 1500,
                        IsFavorite = true,
                        IsAvailable = true,
                        Category =_laptopsCategory.AllCategories.ElementAt(3)
                    },

                    new Laptop
                    {
                        Name = "Dell G7 17 ",
                        ShortDesc = "Huuuuge screen",
                        LongDesc = "",
                        Img ="/png/Dell G7 17.jpeg",
                        Price = 1600,
                        IsFavorite = false,
                        IsAvailable = true,
                        Category =_laptopsCategory.AllCategories.ElementAt(3)
                    },

                    new Laptop
                    {
                        Name = "Lenovo IdeaPad 330-15ICH",
                        ShortDesc = "Business class",
                        LongDesc = "",
                        Img ="/png/Lenovo IdeaPad 330-15ICH.jpg",
                        Price = 1050,
                        IsFavorite = true,
                        IsAvailable = true,
                        Category =_laptopsCategory.AllCategories.ElementAt(4)
                    },

                    new Laptop
                    {
                        Name = "Lenovo IdeaPad 330-15IKB ",
                        ShortDesc = "Balance",
                        LongDesc = "",
                        Img ="/png/Lenovo IdeaPad 330S-15IKB.jpg",
                        Price = 550,
                        IsFavorite = false,
                        IsAvailable = true,
                        Category =_laptopsCategory.AllCategories.ElementAt(4)
                    },

                    new Laptop
                    {
                        Name = "Lenovo V130-15IKB ",
                        ShortDesc = "Just for home",
                        LongDesc = "",
                        Img ="/png/lenovo_cheap.jpg",
                        Price = 340,
                        IsFavorite = false,
                        IsAvailable = true,
                        Category =_laptopsCategory.AllCategories.ElementAt(4)
                    },
                    

                };

            }
        }
        public IEnumerable<Laptop> GetFavLaptops { get; set; }
        public Laptop LaptopObj(int lapId)
        {
            throw new NotImplementedException();
        }
    }
}
