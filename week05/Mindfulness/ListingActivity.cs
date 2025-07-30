public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<int> _usedIndexes = new List<int>();
    private List<string> _entry = new List<string>();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void Run()
    {
        Console.WriteLine("List as many responds you can to the following prompt: ");
        GetRandomPrompt();
        DisplayListFromUser();
    }

    public void GetRandomPrompt()
    {
        if (_usedIndexes.Count == _prompts.Count)
        {
            _usedIndexes.Clear();
        }
        Random random = new Random();
        int index;
        do
        {
            index = random.Next(_prompts.Count);
        }
        while (_usedIndexes.Contains(index));
        Console.WriteLine(_prompts[index]);
        _usedIndexes.Add(index);
    }

    public void DisplayListFromUser()
    {
        Console.Write("You may begin in:");
        ShowCountDown(3);
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string enter = Console.ReadLine();
            _entry.Add(enter);
        }
        SetCount();
    }

    public void SetCount()
    {
        _count = _entry.Count;
    }

    public string GetCount()
    {
        return $"{_count}";
    }
}