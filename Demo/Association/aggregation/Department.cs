using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.aggregation
{
    internal class Department
    {
        public int code { get; set; }
        public required string name { get; set; }
        public List<Employee>? Employee { get; set; }
    }
}
