using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries { get; set; } = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    
    public void SaveToFile(string filename)
    {
        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(_entries, options);
        File.WriteAllText(filename, jsonString);
        Console.WriteLine("Journal saved as JSON.");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        if (File.Exists(filename))
        {
         string jsonString = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
            Console.WriteLine("Journal loaded from JSON.");
            DisplayAll();
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }


        
}