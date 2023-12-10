using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 15);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("orange", 5, 5);
        shapes.Add(rectangle);

        Circle circle = new Circle("red", 6);
        shapes.Add(circle);
        
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"{color} - {area}");
        }
    }
}