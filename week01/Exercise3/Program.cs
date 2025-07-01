using System;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        string play = "yes";
        while (play == "yes")
        {
            Random magicGenerator = new Random();
            int magic = magicGenerator.Next(1, 100);
            int guess = int.MinValue;
            int numberOffGuess = 0;
            while (magic != guess)
            {
                numberOffGuess++;
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess == magic)
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine($"You made {numberOffGuess} guesses");
            Console.Write("Do you want to play again? ");
            play = Console.ReadLine();
            play = play.ToLower();
        }
    }
}