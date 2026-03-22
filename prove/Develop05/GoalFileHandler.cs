using System.Security.Principal;
using System.Text.Json;

public class GoalfileHandler
{
    public void Save(string filename, int score, List<Goal> goals)
    {
        var saveData = new SaveData
        {
            Score = score,
            Goals = goals.Select(ToData).ToList()
        };

        string json = JsonSerializer.Serialize(saveData, new JsonSerializerOptions
        {
            //I want to be actually able to read the thing ;) 
            WriteIndented = true
        });
        File.WriteAllText(filename, json);
    }

    public (int score, List<Goal> goals) Load(string filename)
    {
        // Reads the file and deserializes it if it exists
        if (!File.Exists(filename))
        {
            throw new FileNotFoundException($"File not found, maybe try a different one {filename}");
        }
        string json = File.ReadAllText(filename);
        var raw = JsonSerializer.Deserialize<SaveData>(json);

        // Reconstruct Goal objects from the file
       List<Goal> goals = raw.Goals.Select(CreateGoalFromData).ToList();
       return (raw.Score, goals);
    }

// Converts a live Goal object flat GoalData for serialization
    private GoalData ToData(Goal goal) => goal switch
    {

        SimpleGoal g => new GoalData
        {
            Type        = GoalTypes.Simple,
            Name        = g.GetName(),
            Description = g.GetDescription(),
            Points      = g.GetPoints(),
            IsComplete  = g.IsComplete()
        },
        EternalGoal g => new GoalData
        {
            Type          = GoalTypes.Eternal,
            Name          = g.GetName(),
            Description   = g.GetDescription(),
            Points        = g.GetPoints(),
            TimesRecorded = g.GetTimesRecorded()
        },
        ChecklistGoal g => new GoalData
        {
            Type            = GoalTypes.Checklist,
            Name            = g.GetName(),
            Description     = g.GetDescription(),
            Points          = g.GetPoints(),
            AmountCompleted = g.GetAmountCompleted(),
            TargetAmount    = g.GetTargetAmount(),
            Bonus           = g.GetBonus()
        },
        NegativeGoal g => new GoalData
        {
            Type          = GoalTypes.Negative,
            Name          = g.GetName(),
            Description   = g.GetDescription(),
            Points        = g.GetPoints(),
            Penalty       = g.GetPenalty(),
            TimesRecorded = g.GetTimesRecorded()
        },
        StreakGoal g => new GoalData
        {
            Type             = GoalTypes.Streak,
            Name             = g.GetName(),
            Description      = g.GetDescription(),
            Points           = g.GetPoints(),
            CurrentStreak    = g.GetCurrentStreak(),
            LongestStreak    = g.GetLongestStreak(),
            RequiredStreak   = g.GetRequiredStreak(),
            StreakBonus      = g.GetStreakBonus(),
            LastRecordedDate = g.GetLastRecordedDate()
        },
        _ => throw new ArgumentException($"Unknown goal type: {goal.GetType().Name}")
    };

    // Converts a flat GoalData DTO → the correct Goal subclass
    private Goal CreateGoalFromData(GoalData data)
    {
        switch (data.Type)
        {
            case GoalTypes.Simple:
                return new SimpleGoal(
                    data.Name, 
                    data.Description, 
                    data.Points, 
                    data.IsComplete
                );

            case GoalTypes.Eternal:
                return new EternalGoal(
                    data.Name, 
                    data.Description, 
                    data.Points, 
                    data.TimesRecorded
                );

            case GoalTypes.Checklist:
                return new ChecklistGoal(
                    data.Name, 
                    data.Description, 
                    data.Points,
                    data.TargetAmount, 
                    data.Bonus, 
                    data.AmountCompleted
                );

            case GoalTypes.Negative:
                return new NegativeGoal(
                    data.Name, 
                    data.Description, 
                    data.Points,
                    data.TimesRecorded,
                    data.Penalty
                    
                );

            case GoalTypes.Streak:
                return new StreakGoal(
                    data.Name, 
                    data.Description, 
                    data.Points,
                    data.RequiredStreak, 
                    data.StreakBonus,
                    data.CurrentStreak, 
                    data.LongestStreak, 
                    data.LastRecordedDate
                );

            default:
                throw new InvalidDataException($"Unknown goal type in save file: '{data.Type}'");
        }
    }
}