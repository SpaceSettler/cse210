using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square1 = new Square("blue", 23);
        shapes.Add(square1);
        Rectangle rect1 = new Rectangle(23, 32, "blue");
        shapes.Add(rect1);
        Circle circ1 = new Circle(3.2, "blue");
        shapes.Add(circ1);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
        }
    }
}