public class GoalData
{
    public string Type { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    // SimpleGoal
    public bool IsComplete { get; set; }

    // EternalGoal + NegativeGoal
    public int TimesRecorded { get; set; }

    // NegativeGoal
    public int Penalty { get; set; }

    // ChecklistGoal
    public int AmountCompleted { get; set; }
    public int TargetAmount { get; set; }
    public int Bonus { get; set; }

    // StreakGoal
    public int CurrentStreak { get; set; }
    public int LongestStreak { get; set; }
    public int RequiredStreak { get; set; }
    public int StreakBonus { get; set; }
    public DateTime LastRecordedDate { get; set; }
}