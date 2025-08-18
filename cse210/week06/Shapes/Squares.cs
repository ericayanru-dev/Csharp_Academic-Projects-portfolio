public class Square : Shapes
{
    private double _length;

    public Square(double length)
    {
        _length = length;
    }

    public override double GetArea()
    {
        return _length * _length;
    }
}