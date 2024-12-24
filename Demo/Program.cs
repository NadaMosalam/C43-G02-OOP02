namespace Demo
{
    class Program
    {
        // entry point
        static void Main()
        {
            #region Part 01 Struct
            //Point p1;
            ////Declare for object of type  "point"
            ////CLR will allocate 8 uninitialized bytes in stack

            //p1 = new Point(1,2);        //parameterless constructor
            ////Console.WriteLine(p1.x); 
            ////Console.WriteLine(p1.y); 
            //Console.WriteLine(p1);
            //Console.WriteLine(p1.ToString());
            #endregion

            #region Part 04 OOP Pillars - Encapsulation

            //Employee employee = new Employee(1001, "Nada Mosalam", 10_000,44);

            //employee.Setid(2002);          //setter 
            //Console.WriteLine(employee.Getid()); //Getter
            //employee.Name = "Nour Ahmed";        //setter 
            //Console.WriteLine(employee.Name);    //Getter

            #endregion

            #region Part 05 Encapsulation (Continued) - Indexer

            //PhoneBook note = new PhoneBook();
            //note.Addperson(0, "Nada", 111);
            //note.Addperson(1, "Nour", 222);
            //note.Addperson(2, "Alia", 333);
            //note.Addperson(3, "Ali", 444);

            //note.SetNumber("Nada", 999);
            // note["nada"] = 99999;

            //  Console.WriteLine(note.GetNumber("Nada"));
            //Console.WriteLine(note["Nada"]);


            #endregion

            #region Part 06 Class

            //Car C1 = new Car(2003, "kia", 110); 
            //Console.WriteLine(C1);

            #endregion

        }
    }
}
