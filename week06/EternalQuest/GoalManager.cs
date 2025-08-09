using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _currentStreak;
    private int _longestStreak;
    private DateTime _lastCompletionDate;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        DisplayPlayerInfo();

        int choice;
        do
        {
            Console.WriteLine($"\nScore: {_score} | Current Streak: {_currentStreak} days | Longest Streak: {_longestStreak} days");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoalDetails(); break;
                case 3: SaveGoals(); break;
                case 4: LoadGoals(); break;
                case 5: RecordEvent(); break;
            }

        } while (choice != 6);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal item in _goals)
        {
            Console.WriteLine(item.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine(" 4. Return to main menu");

        if (!int.TryParse(Console.ReadLine(), out int goalType) || goalType < 1 || goalType > 4)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        if (goalType == 4) return;

        Console.Write("Name of goal: ");
        string name = Console.ReadLine();
        Console.Write("Short description: ");
        string description = Console.ReadLine();
        int points = GetIntFromUser("Point value: ");

        if (goalType == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType == 3)
        {
            int target = GetIntFromUser("How many times for bonus: ");
            int bonus = GetIntFromUser("Bonus points: ");
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        int index = GetIntFromUser("Which goal did you accomplish? ") - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();
            _score += earned;

            Console.WriteLine($"You earned {earned} points!");
            UpdateStreak();
            Console.WriteLine($"Current streak: {_currentStreak} days (Longest: {_longestStreak} days)");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("File name to save: ");
        string fileName = Console.ReadLine();
        var saveData = new SaveData(_goals, _score, _currentStreak, _longestStreak, _lastCompletionDate);

        var settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            TypeNameHandling = TypeNameHandling.All
        };

        string jsonString = JsonConvert.SerializeObject(saveData, settings);
        File.WriteAllText(fileName, jsonString);

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("File name to load: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        var settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        };

        string jsonString = File.ReadAllText(fileName);
        var saveData = JsonConvert.DeserializeObject<SaveData>(jsonString, settings);

        _goals = saveData.Goals;
        _score = saveData.Score;
        _currentStreak = saveData.CurrentStreak;
        _longestStreak = saveData.LongestStreak;
        _lastCompletionDate = saveData.LastCompletionDate;

        Console.WriteLine("Goals loaded.");
    }

    private int GetIntFromUser(string prompt)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Invalid number, try again.");
        }
    }
    private void UpdateStreak()
    {
        DateTime today = DateTime.Today;
        if (_lastCompletionDate == default) // first goal ever
        {
            _currentStreak = 1;
        }
        else
        {
            int daysDiff = (today - _lastCompletionDate).Days;
            if (daysDiff == 1)
                _currentStreak++;
            else if (daysDiff > 1)
                _currentStreak = 1; // reset streak
        }

        if (_currentStreak > _longestStreak)
            _longestStreak = _currentStreak;

        _lastCompletionDate = today;
    }
}