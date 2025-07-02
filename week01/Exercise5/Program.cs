using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }
        static double SquareNumber(int number)
        {
            double squareNumber = number * number;
            return squareNumber;
        }
        static void DisplayResult(string userName, double square)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        double square = SquareNumber(userNumber);
        DisplayResult(userName, square);
    }
}