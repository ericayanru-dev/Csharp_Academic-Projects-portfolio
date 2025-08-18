using Newtonsoft.Json;

public class SimpleGoal : Goal
{
    [JsonProperty] private bool _isCompleted;

    protected SimpleGoal() : base() { } // For JSON

    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _isCompleted = false;
    }

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _isCompleted;

    public override string GetStringRepresentation()
    {
        string statusSymbol = _isCompleted ? "[✔️]" : "[ ]";
        return $"{statusSymbol} {_shortName} — {_description}";
    }
}
