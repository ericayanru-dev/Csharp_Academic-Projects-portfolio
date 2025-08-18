using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 0;
        Console.Write("Enter number: ");
        number = int.Parse(Console.ReadLine());
        numbers.Add(number);
        while (true)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }
        double sum = 0;
        int maximum = 0;
        int minimum = int.MaxValue;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];
            if (maximum < numbers[i])
            {
                maximum = numbers[i];
            }
            if (minimum > numbers[i] && numbers[i] > 0)
            {
                minimum = numbers[i];
            }
        }

        double average = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maximum}");
        Console.WriteLine($"The smallest positive number is: {minimum}");
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}