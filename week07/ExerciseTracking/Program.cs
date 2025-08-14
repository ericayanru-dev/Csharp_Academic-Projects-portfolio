using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
         List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0),
            new Cycling("04 Nov 2022", 45, 12.0),
            new Swimming("05 Nov 2022", 25, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}