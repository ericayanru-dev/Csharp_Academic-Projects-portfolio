using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fractions fraction = new Fractions();
        fraction.GetFractionString();
        fraction.GetFractionValue();

        int top = 1;
        int bottom = 3;
        Fractions fraction1 = new Fractions(top);
        fraction1.GetFractionString();
        fraction1.GetFractionValue();

        Fractions fraction2 = new Fractions(top, bottom);
        fraction2.GetFractionString();
        fraction2.GetFractionValue();

        Fractions fraction3 = new Fractions();
        fraction3.SetTop(top);
        fraction3.SetBottom(bottom);
        fraction3.GetFractionString();
        fraction3.GetFractionValue();

    }
}