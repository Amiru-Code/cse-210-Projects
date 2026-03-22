public class SimpleGoal : Goal
{
    private bool _isComplete;

// simple constructor, inherits from goal
    public SimpleGoal(string name, string description, int points,bool isComplete)
    : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if(_isComplete) return 0; // already done, no points for doing it multiple times (unlike checklist)
        _isComplete = true;
        return _points;
    }


// lamboda function, sets IsComplete to true or false depending on the status of _isComplete
    public override bool IsComplete() => _isComplete;

// I dont actually need GetDetailsString here because the defaults I set in the base class are fine

}