public class EternalGoal : Goal
{
    public int _timesRecorded = 0;

    public EternalGoal(string name, string description, int points, int timesRecorded)
    : base(name, description, points)
    {
        _timesRecorded = timesRecorded;
    }

//Increases the number of times recorded by one and returns the number of points the goal is worth
    public override int RecordEvent()
    {
        _timesRecorded ++;
        return _points;
    }

// Never complete (eternal goal)
    public override bool IsComplete() => false;

// Adds the number of times recorded to the get details function 
    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $"Recorded {_timesRecorded} times";
    }

    public int GetTimesRecorded() => _timesRecorded;
}