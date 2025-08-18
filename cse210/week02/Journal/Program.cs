using System;
// ==================================================
// This program exceeds core requirements by:
// - Implementing JSON serialization for saving/loading entries.
// This allows structured storage, easier data parsing, and 
// demonstrates use of the System.Text.Json namespace.
// ==================================================
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("===========================================");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("===========================================");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.Write(prompt);
                string entryText = Console.ReadLine();
                Entry entry = new Entry();
                entry._promptText = prompt;
                entry._entryText = entryText;
                journal._entries.Add(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Enter the File name: ");
                string file = Console.ReadLine();
                file += ".csv";
                journal.SaveToFile(file);
            }

            else if (choice == 4)
            {
                Console.Write("Enter the File name: ");
                string file = Console.ReadLine();
                file += ".csv";
                journal.LoadFromFile(file);
            }

            else if (choice == 5)
            {
                break;
            }
        }
    }
}