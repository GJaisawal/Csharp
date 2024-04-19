using System;

namespace InheritanceExample
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public int YearlySalary = 300000;

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Salary: {YearlySalary}");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public int HourSalary = 1000;

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Hourly Salary: {HourSalary}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Employee objEmployee;

            objEmployee = new FullTimeEmployee();
            objEmployee.FirstName = "John";
            objEmployee.LastName = "Doe";
            objEmployee.DisplayDetails();

            Console.WriteLine();

            objEmployee = new PartTimeEmployee();
            objEmployee.FirstName = "Gautam";
            objEmployee.LastName = "Jaisawal";
            objEmployee.DisplayDetails();
        }
    }
}

