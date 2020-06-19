using System.Collections.Generic;
using OnlineStore.Data.Interfaces;
using OnlineStore.Data.Models;

namespace OnlineStore.Data.Mocks
{
    public class MockCategory : ILaptopsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName = "Xiaomi", Desk = "They are like MAC laptops but under the Windows OS and twice cheaper"},
                    new Category {CategoryName = "Apple", Desk = "Expensive laptops with under the MAC OS "},
                    new Category{CategoryName = "Asus", Desk = "Stylish laptops with impressive perfomance"},
                    new Category{CategoryName = "Dell", Desk = "Quality from the USA"},
                    new Category{CategoryName = "Lenovo", Desk = "Cheap decision for everyone"}
                };

            }
        }

    }
}