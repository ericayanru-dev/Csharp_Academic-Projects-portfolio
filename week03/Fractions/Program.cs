using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction f1 = new Fraction(); // 1/1
        f1.GetFractionString();
        f1.GetDecimalValue();

        Fraction f2 = new Fraction(5); // 5/1
        f2.GetFractionString();
        f2.GetDecimalValue();

        Fraction f3 = new Fraction(3, 4); // 3/4
        f3.GetFractionString();
        f3.GetDecimalValue();

        Fraction f4 = new Fraction(1, 3); // 1/3
        f4.GetFractionString();
        f4.GetDecimalValue();

        // Testing getters and setters
        f4.SetTop(2);
        f4.SetBottom(5);
        f4.GetFractionString(); // Should output 2/5
        f4.GetDecimalValue(); // Should output 0.4

    }
}