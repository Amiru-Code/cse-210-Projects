public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonus;

public ChecklistGoal(string name, string description, int points, int targetAmount, int amountCompleted, int bonus)
    : base(name, description, points)
    {
        targetAmount = _targetAmount;
        amountCompleted = _amountCompleted;
        bonus = _bonus;
    }

//If it has not been completed it returns a score and a bonus if this is the final time needed to complete it
    public override int RecordEvent()
    {
        if(IsComplete()) return 0;

        _amountCompleted++;

        return IsComplete() ? _points + _bonus : _points;
    }

// tells me if it's complete or not
    public override bool IsComplete() => _amountCompleted >= _targetAmount;

// add the amount of times completed out of the total
    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $"This goal has been completed {_amountCompleted}/{_targetAmount} times";
    }

    // getters for the member variables because i'll need them later but this class will not be a parent class
    public int GetAmountCompleted() => _amountCompleted;
    public int GetTargetAmount() => _targetAmount;
    public int GetBonus() => _bonus;
}