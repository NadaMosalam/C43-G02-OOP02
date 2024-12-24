using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    #region Question 4
    enum SecurityLevel
    {
        Guest, Developer, Secretary, DBA
    }

    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public SecurityLevel SecurityLevel { get; }
        public decimal salary { get; set; }
        public DateTime hiredate { get; set; }
        public char gender { get; set; }

        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, DateTime hireDate, char gender)
        {
            this.Id = id;
            this.Name = name;
            this.SecurityLevel = securityLevel;
            this.salary = salary;
            this.hiredate = hireDate;
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Gender: {gender}, Security Level: {SecurityLevel}, Salary: {salary:C}, Hire Date: {hiredate:yyyy-MM-dd}";
        }


    }
    #endregion

    #region Question 5
    internal class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public bool IsValidDate()
        {
            return DateTime.TryParse($"{Year}-{Month}-{Day}", out _);
        }
        public override string ToString()
        {
            return $"{Year:0000}-{Month:00}-{Day:00}";
        }
    }
    #endregion
}
