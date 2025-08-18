using System;

public class Entry
{
    public DateTime CurrentDate { get; set; } = DateTime.Now;
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }

    public void Display()
    {
        string displayDate;
        if (string.IsNullOrEmpty(_date))
        {
            displayDate = CurrentDate.ToShortDateString();
        }
        else
        {
            displayDate = _date;
        };
        Console.WriteLine($"Date: {displayDate}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}
