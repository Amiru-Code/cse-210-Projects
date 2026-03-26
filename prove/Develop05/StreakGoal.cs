public class StreakGoal : Goal
{
    private int _currentStreak;
    private int _longestStreak;
    private int _streakBonus;
    private int _requiredStreak;
    private DateTime _lastRecordedDate;

    public StreakGoal(string name, string description, int points, int currentStreak, int longestStreak, int streakBonus, int requiredStreak, DateTime lastRecordedDate)
    : base(name, description, points)
    {
        _currentStreak = currentStreak;
        _longestStreak = longestStreak;
        _streakBonus = streakBonus;
        _requiredStreak = requiredStreak;
        _lastRecordedDate = lastRecordedDate;
    }

    public override int RecordEvent()
    {
       DateTime today = DateTime.Today;

       if(_lastRecordedDate == today) return 0;

        bool isConsecutiveDay = _lastRecordedDate == today.AddDays(-1);

        _currentStreak = isConsecutiveDay ? _currentStreak + 1 : 1;
        _lastRecordedDate = today;

        if(_currentStreak > _longestStreak) _currentStreak = _longestStreak;

bool bonusEarned = _currentStreak % _requiredStreak == 0;
        return bonusEarned ? _points + _streakBonus : _points;
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        string bonus = _currentStreak % _requiredStreak == 0 && _currentStreak > 0 
        ? "Bonus Streak!" : $" ({_requiredStreak - (_currentStreak % _requiredStreak)} to next bonus)";
        return base.GetDetailsString()
            + $" — streak: {_currentStreak} days | best: {_longestStreak}{bonus}";
    }

    public int GetCurrentStreak() => _currentStreak;
    public int GetLongestStreak() => _longestStreak;
    public int GetStreakBonus() => _streakBonus;
    public int GetRequiredStreak() => _requiredStreak;
    public DateTime GetLastRecordedDate() => _lastRecordedDate; 
}