using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using Assignment.Struct;
using System.Drawing;
using Assignment.Classes;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            #region Question 1
            //1.Define a struct "Person" with properties "Name" and "Age".
            //Create an array of three "Person" objects and populate it with data.
            //Then, write a C# program to display the details of all the persons in the array.

            //Person[] people = new Person[3];
            //people[0] = new Person("Nada", 23);
            //people[1] = new Person("Nour", 30);
            //people[2] = new Person("Alia", 28);
            //foreach (var person in people)
            //{
            //    Console.WriteLine(person.ToString());
            //}

            #endregion

            #region Question 2
            //2.Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates
            //the distance between them.

            //do
            //{

            //    Console.Write("Please enter the point X1 : ");
            //    bool isX1Valid = double.TryParse(Console.ReadLine(), out double X1);

            //    Console.Write("Please enter the point Y1 : ");
            //    bool isY1Valid = double.TryParse(Console.ReadLine(), out double Y1);

            //    Console.Write("Please enter the point X2 : ");
            //    bool isX2Valid = double.TryParse(Console.ReadLine(), out double X2);

            //    Console.Write("Please enter the point Y2 : ");
            //    bool isY2Valid = double.TryParse(Console.ReadLine(), out double Y2);

            //    double x = X1 - X2;
            //    double y = Y1 - Y2;

            //    if (isX1Valid && isY1Valid && isX2Valid && isY2Valid)
            //    {
            //        Point p1 = new Point(X1, Y1);
            //        Point p2 = new Point(X2, Y2);
            //        double distance = point.CalculateDistance(p1, p2);

            //        Console.WriteLine($"The distance between the points is : {distance}");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your input invalid => Please enter valid double values. ");
            //        Console.WriteLine("********************");
            //        Console.WriteLine();
            //    }

            //} while (true);

            #endregion

            #region Question 3
            //3.Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from
            //the user and displays the name and age of the oldest person.

            //Person person1, person2, person3;
            //Console.Write("Please Enter The First Name : ");
            //string? name1 =(Console.ReadLine());
            //Console.Write("Please Enter The First Age : ");
            //int.TryParse(Console.ReadLine(), out int age1);
            //person1 = new Person(name1, age1);

            //Console.Write("Please Enter The Second Name : ");
            //string? name2 = (Console.ReadLine());
            //Console.Write("Please Enter The Second Age : ");
            //int.TryParse(Console.ReadLine(), out int age2);
            //person2 = new Person(name2, age2);

            // Console.Write("Please Enter The Third Name : ");
            //string? name3 = (Console.ReadLine());
            //Console.Write("Please Enter The Second Age : ");
            //int.TryParse(Console.ReadLine(), out int age3);

            //person3 = new Person(name3, age3);

            //Person oldestPerson = person1;

            //if (person2.Age > oldestPerson.Age)
            //{
            //    oldestPerson = person2;
            //}
            //if (person3.Age > oldestPerson.Age)
            //{
            //    oldestPerson = person3;
            //    Console.WriteLine($"oldest person = {oldestPerson.Name}, Age = {oldestPerson.Age}");
            //}
            #endregion

            #region Question 4
            //1.Design and implement a Class for the employees in a company:
            //Notes:
            //●	Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            //●	We need to restrict the Gender field to be only M or F[Male or Female]
            //●	Assign the following security privileges to the employee(guest, Developer, secretary and DBA)
            //  in a form of Enum.
            //●	We want to provide the Employee Class to represent Employee data in a string Form
            //  (override ToString()), display employee salary in a currency format.[Use String.Format() Function].

            //Console.Write("Please Enter ID : ");
            //int.TryParse(Console.ReadLine(), out int id );
            //Console.Write("Please Enter Name : ");
            //string? name = Console.ReadLine();
            //SecurityLevel securityLevel;
            //while (true)
            //{
            //    Console.Write("Please Enter Security Level (Guest/Developer/Secretary/DBA) : ");
            //    string? Sec = Console.ReadLine();
            //    if (Enum.TryParse(Sec, true, out securityLevel))
            //        break;
            //    Console.WriteLine("Invalid Security Level");
            //}
            //Console.Write(" Please Enter Salary: ");
            //decimal salary = decimal.Parse(Console.ReadLine());
            //Console.Write("Please Enter Hire Date (yyyy-mm-dd): ");
            //DateTime hireDate = DateTime.Parse(Console.ReadLine());
            //char gender;
            //while (true)
            //{
            //    Console.Write("Please Enter Gender (M/F): ");
            //    gender = char.ToUpper(Console.ReadLine()[0]);
            //    if (gender == 'M' || gender == 'F')
            //        break;
            //    Console.WriteLine("Invalid Gender.");
            //}
            //Employee employee = new Employee(id, name, securityLevel, salary, hireDate, gender);
            //Console.WriteLine(employee.ToString());
            #endregion

            #region Question 5
            //2- Develop a Class to represent the Hiring Date Data:
            //●	Consisting of fields to hold the day, month and Years.

            //int day, month, year;
            //while (true)
            //{
            //    Console.Write("Please Enter The Date 1-31 :");
            //    if (int.TryParse(Console.ReadLine(), out day) && day >= 1 && day <= 31)
            //        break;
            //    Console.WriteLine("Invalid Please Enter The Date 1-31.");
            //}
            //while (true)
            //{
            //    Console.Write(" Please Enter The Monthe 1-12 :");
            //    if (int.TryParse(Console.ReadLine(), out month) && month >= 1 && month <= 12)
            //        break;
            //    Console.WriteLine("Invalid Please Enter The Month 1-12");
            //}
            //while (true)
            //{
            //    Console.Write("Please Enter the year (positive number) ");
            //    if (int.TryParse(Console.ReadLine(), out year) && year > 0)
            //        break;
            //    Console.WriteLine("Invalid Year must be a (positive number).");
            //}
            //HiringDate hiringDate = new HiringDate(day, month, year);
            //if (hiringDate.IsValidDate())
            //{
            //    Console.WriteLine($"Employment history: {hiringDate}");
            //}
            //else
            //{
            //    Console.WriteLine("The Enter Date Is Invalid..");
            //}
            #endregion

            #region Question 6
            //3-Create an array of Employees with size three a DBA,
            //Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            //Notes:
            //●	Implement All the Necessary Member Functions on the Class(Getters, Setters)
            //●	Define all the Necessary Constructors for the Class
            //●	Allow NO RUNTIME errors if the user inputs any data
            //●	Write down all the necessary Properties(Instead of setters and getters)

            #endregion

            #region Question 7
            //4- Sort the employees based on their hire date then Print the sorted array.
            //●	While sorting(how many times Boxing and Unboxing process has occurred)
            #endregion




        }
    }
}