public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
       "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<int> _usedIndexes = new List<int>();

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    public void Run()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        DisplayQuestion();

    }

    public int GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return index;

    }

    public void DisplayPrompt()
    {
        string prompt = _prompts[GetRandomPrompt()];
        Console.WriteLine($"--- {prompt} ---");
    }

    public int GetRandomQuestion()
    {
        if (_usedIndexes.Count == _questions.Count)
        {
            _usedIndexes.Clear();
        }

        Random random = new Random();
        int index;

        do
        {
            index = random.Next(_questions.Count);
        }
        while (_usedIndexes.Contains(index));
        _usedIndexes.Add(index);
        return index;
    }
    
     public void DisplayQuestion()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        do
        {
            Console.WriteLine("");
            string question = _questions[GetRandomQuestion()];
            Console.WriteLine(question);
            ShowSpinner(10);
        } while (DateTime.Now < endTime);
        
    }
}