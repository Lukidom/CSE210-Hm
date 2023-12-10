public class Rectangle : Shape
{
       public string color;

    private double _width;
    private double _length;

    public Rectangle(string color, int width, int length) : base (color)
    {
        _width = width;
        _length = length;
    }

    public override double GetArea()
    {
        return _width * _length;
    }

}