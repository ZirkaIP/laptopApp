using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using OnlineStore.Data.Models;

namespace OnlineStore.Data.Interfaces
{
    public interface ILaptopsCategory
    {
       IEnumerable<Category> AllCategories { get; }
    }
}