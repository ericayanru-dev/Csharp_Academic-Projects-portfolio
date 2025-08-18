using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter your grade: ");
        string grade = Console.ReadLine();
        int gradeValue = int.Parse(grade);

        if (gradeValue > 89 && gradeValue < 101)
        {
            Console.Write("A");
        }
        else if (gradeValue > 79 && gradeValue < 90)
        {
            Console.Write("B");
        }
        else if (gradeValue > 69 && gradeValue < 80)
        {
            Console.Write("C");
        }
        else if (gradeValue > 59 && gradeValue < 70)
        {
            Console.Write("D");
        }
        else if (gradeValue < 60 && gradeValue > -1)
        {
            Console.Write("F");
        }
        else
        {
            Console.Write($"{grade} is not a valid number enter. enter a number between 0 to 100");
        }

        if (gradeValue > 69 && gradeValue < 101)
        {
            int ability = gradeValue % 10;
            if (ability >= 7)
            {
                string sign = "+";
                Console.Write(sign);
            }
            else if (ability < 3)
            {
                string sign = "-";
                Console.WriteLine(sign);
            }
            else
            {
                Console.WriteLine("");
            }

            Console.WriteLine("Congratulation you passed the course");
            
        }
        else if (gradeValue < 70 && gradeValue > -1)
        {
            int ability = gradeValue % 10;
            if (ability >= 7)
            {
                string sign = "+";
                Console.WriteLine(sign);
            }
            else if (ability < 3)
            {
                string sign = "-";
                Console.WriteLine(sign);
            }
            else
            {
                Console.WriteLine("");
            }
            Console.WriteLine("Try and do better next term");
        }
    }
}