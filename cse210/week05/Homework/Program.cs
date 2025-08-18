using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        assignment.GetSummary();

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        mathAssignment.GetSummary();
        mathAssignment.GetHomeworkList();

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        writingAssignment.GetSummary();
        writingAssignment.GetWritingInformation();
    }
}