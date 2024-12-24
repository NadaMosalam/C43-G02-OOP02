using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.aggregation
{
    internal class Employee
    {
        public int Id { get; set; }
        public required string FName { get; set; }
        public required string LName { get; set; }
        public int Age { get; set; }
        public decimal salary { get; set; }
        public Department? Department{ get; set; }
    }
}
