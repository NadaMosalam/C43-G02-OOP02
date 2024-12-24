using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.composition
{
    internal class Order
    {
        public int Id { get; set; }
        public required string UserEmail { get; set; }
        public decimal SubTotal {  get; set; }
        public required List<OrderItem> Items{ get; set; }

    }
}
