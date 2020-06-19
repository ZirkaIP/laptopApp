using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int LaptopId { get; set; }
        public uint Price { get; set; }
       
        public virtual  Laptop laptop { get; set; }
        public virtual Order order { get; set; }

    }
}
