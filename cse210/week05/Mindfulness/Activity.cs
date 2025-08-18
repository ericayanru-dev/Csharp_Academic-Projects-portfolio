public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write($"How long, in seconds, would you like for your session?  ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Get ready in 5 seconds....");
        ShowSpinner(5);
        Console.WriteLine("");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(11);
        Console.WriteLine("");
        Console.WriteLine($"You just completed a {_name}");
        ShowSpinner(3);
        Console.WriteLine($"The length of this was {_duration} seconds");
        ShowSpinner(3);
    }

    public void ShowCountDown(int seconds)
    {
        int i = seconds;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write(new string('\b', i.ToString().Length));
            Console.Write(new string(' ', i.ToString().Length));
            Console.Write(new string('\b', i.ToString().Length));
            i--;
        }
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string symbol = animationStrings[i];
            Console.Write($"{symbol}");
            Thread.Sleep(300);
            Console.Write(new string('\b', symbol.ToString().Length));
            Console.Write(new string(' ', symbol.ToString().Length));
            Console.Write(new string('\b', symbol.ToString().Length));
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
}