using Newtonsoft.Json;

public abstract class Goal
{
    [JsonProperty] protected string _shortName;
    [JsonProperty] protected string _description;
    [JsonProperty] protected int _points;

    protected Goal() { } // For JSON deserialization

    protected Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetName() => _shortName;
    public string GetDescription() => _description;

    public abstract int RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}
