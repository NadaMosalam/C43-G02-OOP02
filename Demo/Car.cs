using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
        #region Part 06 Class

        #region Attributes

        private int id;         //4  Bytes
        private String? model;  //4  Bytes
        private decimal speed;  //16 Bytes

        #endregion

        #region properties 
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String? Model
        {
            get { return model; }
            set { model = value; }
        }

        public decimal Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        #endregion

        #region constructor

        //If No User Defined Cconstructor Exists, 
        //Compiler Will Generate Empty Parameterless Constructor [Do Nothing]

        public Car()
        {

        }

        //If You Defined a Cconstructor, Compiler Will No Longer Generate Empty Parameterless Constructor.

        public Car(int id, string model, decimal speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;
        }

        public Car(int id, string model)
        {
            this.id = id;
            this.model = model;
            this.speed = 180;
        }

        public Car(int id) :this(id, "kia", 110)  /*constructor chaining*/
        {
            //this.id = id;
            //this.model ="kia";
            //this.speed = 110;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Id={this.id}\nModel={this.model}\nSpeed={this.speed}";
        } 

        #endregion

        #endregion
    }
}
