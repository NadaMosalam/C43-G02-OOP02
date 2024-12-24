using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.composition
{
    internal class OrderItem
    {
        public int Id { get; set; }
        public product product { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }


        public OrderItem(product product)
        {
            this.product = product;
        }
    }
}
