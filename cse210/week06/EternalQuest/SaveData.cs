using System.Collections.Generic;
using Newtonsoft.Json;

public class SaveData
{
    [JsonProperty] private List<Goal> _goals;
    [JsonProperty] private int _score;
    [JsonProperty] private int _currentStreak;
    [JsonProperty] private int _longestStreak;
    [JsonProperty] private DateTime _lastCompletionDate;

    [JsonConstructor]
    public SaveData(List<Goal> goals, int score, int currentStreak, int longestStreak, DateTime lastCompletionDate)
    {
        _goals = goals;
        _score = score;
        _currentStreak = currentStreak;
        _longestStreak = longestStreak;
        _lastCompletionDate = lastCompletionDate;
    }

    public List<Goal> Goals => _goals;
    public int Score => _score;
    public int CurrentStreak => _currentStreak;
    public int LongestStreak => _longestStreak;
    public DateTime LastCompletionDate => _lastCompletionDate;
}
