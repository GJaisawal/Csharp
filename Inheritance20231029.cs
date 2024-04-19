using System;

namespace InheritanceExample
{
    public class Employee
    {
        public string FirstName;
        public string LastName ;
        public string Email;

        public void FullName()
        {
            Console.WriteLine(FirstName+" "+LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public int YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public int HourSalary;
    }

    public class Program
    {
        public static void Main(string [] args)
        {
            FullTimeEmployee ObjFte = new FullTimeEmployee();
            
            ObjFte.FirstName = "Gautam";
            ObjFte.LastName = "Jaisawal";
            ObjFte.FullName();

        }
    }
}