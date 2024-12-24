using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct Employee
    {
        #region Part 04 OOP Pillars - Encapsulation

        #region Attributes 

        private int id;
        private string? name;
        private decimal salary;
        //private decimal deduction; /*Derived Attribute*/

        #endregion

        #region Applying Encapsulation throught Getters,Setters [Old Aproach] :

        //Getters:
        public int Getid()
        {
            return id;
        }

        ////Setters:
        public void Setid(int Value)
        {
            id = Value > 1000 && Value < 10_000 ? Value : 9999;  //Control validation
        }

        #endregion

        #region Applying Encapsulation throught Properties [New Aproach] :

        // full Property:
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string? Name
        {
            get
            {
                return name;
            }
            set
            {
                //Data validation
                name = value is null ? null : value.Length <= 10 ? value : value.Substring(0, 10);
            }
        }
        public decimal Salary
        {
            get { return salary; }
            //Data Validation
            set { salary = value >= 5000 ? value : 5000; }
        }
        public decimal Deduction   //ReadOnly Property
        {
            get { return salary * .2M; }
        }

        #endregion

        #region Constructor 
        public Employee(int id, string name, decimal salary, decimal deduction)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        #endregion

        #region Methods 
        public override string ToString()
        {
            return $"id={this.id}\nname={this.name}\nsalary{this.salary:c}\ndeduction{this.Deduction}";
        }

        #endregion

        #region Code snappet
        //private string address;
        //public string Address
        //{
        //    get { return address; }
        //    set { address = value; }
        //}

        //public string Address { get; set; } 

        #endregion

        #endregion

    }
}
