using Newtonsoft.Json;

public class ChecklistGoal : Goal
{
    [JsonProperty] private int _amountCompleted;
    [JsonProperty] private int _target;
    [JsonProperty] private int _bonus;

    protected ChecklistGoal() : base() { } // For JSON

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                return _points + _bonus; // bonus when completed
            }
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return GetDetailsString();
    }
}
