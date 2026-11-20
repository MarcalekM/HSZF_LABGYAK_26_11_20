using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSZF_LABGYAK_26_11_20.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; } = null!;
        
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;
    }
}
