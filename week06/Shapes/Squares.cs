public class Squares : Shapes
{
    private double _length;

    public Squares(double length)
    {
        _length = length;
    }

    public override double GetArea()
    {
        return _length * _length;
    }
}