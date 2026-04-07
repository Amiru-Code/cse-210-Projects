public class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    protected int GetMinutes() => _minutes;
    protected string GetDate() => _date;

    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => (_minutes > 0) ? (GetDistance() / _minutes) * 60 : 0;
    public virtual double GetPace() => (GetDistance() > 0) ? _minutes / GetDistance() : 0;

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min) - " +
        $"Distance: {GetDistance():F1} miles, " +
        $"Speed: {GetSpeed():F1} min per mile, " +
        $"Pace: {GetPace():F2} min per mile";
    }
}