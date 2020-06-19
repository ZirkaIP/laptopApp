using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Data.Models
{
    public class Laptop
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDesc { get; set; }

        public string LongDesc { get; set; }

        public bool IsFavorite { get; set; }

        public ushort Price { get; set; }

        public string Img { get; set; }

        public bool IsAvailable { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
