using System;

namespace user
{
    class userinput
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter first number : ");
            int fistnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int secondnumber = Convert.ToInt32(Console.ReadLine());

            int sum = fistnumber+secondnumber;
            Console.WriteLine("sum of both numbers : "+sum);
        }
    }
}