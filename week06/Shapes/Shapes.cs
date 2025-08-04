public abstract class Shapes
{
    private string _color;

    public abstract double GetArea();

    public void SetColor(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }
}