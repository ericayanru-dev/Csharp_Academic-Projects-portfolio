using System;


// Exceeds core requirements: Streak System
// Tracks how many consecutive days the user completes at least one goal.
// Encourages daily engagement and shows both current and longest streaks.
// Saved & loaded alongside goals and score.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}