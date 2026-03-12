using System;
class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 2);
        double SquareArea = square.GetArea();
        string SquareColour = square.GetColour();

        Circle circle = new Circle("Green", 4);
        double CircleArea = circle.GetArea();
        string CircleColour = circle.GetColour();

        Rectangle rectangle = new Rectangle("Purple", 3, 5);
        double RectangleArea = rectangle.GetArea();
        string RectangleColour = rectangle.GetColour();

        Console.WriteLine($"{SquareArea}, {SquareColour} {CircleArea} {CircleColour} {RectangleArea} {RectangleColour}");

    List<Shape> shapes = new List<Shape>{rectangle, circle, square};

    foreach(Shape i in shapes)
        {
            Console.WriteLine($" The area of the {i.GetColour()} shape is {i.GetArea()}");
        }

    }
}