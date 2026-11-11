using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        // Square square = new Square(4,"blue");
        // Console.WriteLine(square.GetArea());
        // Console.WriteLine(square.GetColor());

        //List<Shape> shapes = new List<Shape>();
        List<Shape> shapes = [];
        Square square = new Square(4,"blue");
        Circle circle = new Circle(5,"red");
        Rectangle rectangle = new Rectangle(4,8,"Yellow");

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape i in shapes)
        {
            Console.WriteLine($"This shape has an area of {i.GetArea()} and it's color is {i.GetColor()}");
            
        }



    }
}