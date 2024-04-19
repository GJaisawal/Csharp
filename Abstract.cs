using System;

// Abstract class with an abstract method
public abstract class Shape
{
    // Abstract method without a body
    public abstract void Draw();

    // Regular method with a body
    public void DisplayArea()
    {
        Console.WriteLine("Calculating area...");
    }
}

// Interface with a method declaration
public interface IDrawable
{
    void Draw();
}

// Concrete class implementing the abstract class and the interface
public class Circle : Shape, IDrawable
{
    // Implementing the abstract method from the abstract class
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }

    // Implementing the method from the interface
    void IDrawable.Draw()
    {
        Console.WriteLine("Drawing from IDrawable interface");
    }
}

class Program
{
    static void Main()
    {
        // Creating an object of the Circle class
        Circle circle = new Circle();

        // Calling methods on the Circle object
        circle.Draw();           // Calls the Draw method from the abstract class
        ((IDrawable)circle).Draw();  // Calls the Draw method from the interface
        circle.DisplayArea();    // Calls the DisplayArea method from the abstract class
    }
}
