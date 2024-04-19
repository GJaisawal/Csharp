using System;

class Program
{
    public void greet()
    {
        Console.WriteLine("Hello");
    }

    public void greet(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    static void Main(string[] args)
    {
        Program nameobject = new Program();

        // Call method without any argument
        nameobject.greet();

        // Call the same method with an argument
        nameobject.greet("Tim");
    }
}
