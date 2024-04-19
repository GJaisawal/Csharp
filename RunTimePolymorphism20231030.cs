using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Draw the shape");
    }
}
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw the circle");
    }
    
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw the Square");
    }
}
    

class RunTimePolymorphism
{
    public static void Main(string [] args)
    {
        Shape shape;

        shape = new Circle();
        shape.Draw();
        shape = new Square();
        shape.Draw();
    }
}
