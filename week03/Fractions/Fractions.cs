public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int number)
    {
        _top = number;
        _bottom = 1;
    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void GetFractionString()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public void GetFractionValue()
    {
        Console.WriteLine((double)_top / _bottom);
    }


}