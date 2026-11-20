using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSZF_LABGYAK_26_11_20.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Category { get; set; } = "";
        public int Price { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
