using System;

// Exceeds core requirements by:
// Make sure no random prompts/questions are selected until they have all been used at least once in that session.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        int choice;
        string input;
        do
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\n 1. Start Breathing activity \n 2. Start Reflecting activity \n 3. Start Listing activity");
            Console.WriteLine("\n 4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
                if (choice == 1)
                {
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.Run();
                    breathingActivity.DisplayEndingMessage();
                }
                else if (choice == 2)
                {
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.DisplayStartingMessage();
                    reflectingActivity.Run();
                    reflectingActivity.DisplayEndingMessage();
                }
                else if (choice == 3)
                {
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DisplayStartingMessage();
                    listingActivity.Run();
                    string count = listingActivity.GetCount();
                    Console.WriteLine($"You listed {count} items!");
                    listingActivity.DisplayEndingMessage();
                }
                else if (choice != 4)
                {
                    Console.WriteLine("Please enter a valid number from 1 to 4.");
                }
            }

            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        }
        while (choice != 4);


    }
}