public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int Minutes => _minutes;
    public string Date => _date;

    public abstract double GetDistance(); 
    public abstract double GetSpeed();    
    public abstract double GetPace();    

    public virtual string GetSummary()
    {
        return $"{Date} {GetType().Name} ({Minutes} min): " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.00} min per mile";
    }
}
