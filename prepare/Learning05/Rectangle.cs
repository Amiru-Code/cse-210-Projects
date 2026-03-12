public class Rectangle : Shape
{
    private double _length;
    private double _height;

    public Rectangle(string colour, double length, double height) : base(colour)
    {
        _length = length;
        _height = height;
    }

    public override double GetArea()
    {
        return _length * _height;
    }

}