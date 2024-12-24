using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Struct
{
    internal struct Person
    {
        #region Question 1
        public string? Name { get; set; }
        public int Age { get; set; }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public override string ToString()
        {
            return $"Name = {Name}\nAge = {Age}";
        }
        #endregion
    }

    internal struct point
    {
        #region Question 2

        private double x;
        private double y;
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static double CalculateDistance(Point p1, Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

    }
    #endregion


    internal struct Person2
    {
        #region Question 3
        public string? Name { get; set; }
        public int Age { get; set; }

        public Person2(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public override string ToString()
        {
            return $"Name = {Name}\nAge = {Age}";
        }
        #endregion
    }

}


