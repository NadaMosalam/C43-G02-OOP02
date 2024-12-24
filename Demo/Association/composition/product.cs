using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.composition
{
    internal class product
    {
        public int id { get; set; }
        public required string Name { get; set; }
        public decimal unitprice { get; set; }
        public int unitsofstock { get; set; }
    }
}
