public class NegativeGoal : Goal
{
    private int _timesRecorded;
    private int _penalty;
    
    public NegativeGoal(string name, string description, int points, int timesRecorded, int penalty)
    : base(name, description, points)
    {
        _timesRecorded = timesRecorded;
        _penalty = penalty; // I want to keep this positive so it shows up
    }

//Records how many times it has been recorded and returns the amount to be subtracted
    public override int RecordEvent()
    {
        _timesRecorded++;
        return -_penalty;
    }

    public override bool IsComplete() => false;

// Adds how many times the habit has been repeated and how many points lost to GetDetails
    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $"-{_penalty} points | bad habit has been repeated {_timesRecorded} times";
    }

//Getters because member variables are private and i'll need their values
public int GetTimesRecorded() => _timesRecorded;
public int GetPenalty() => _penalty;
}
