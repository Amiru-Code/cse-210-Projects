
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    } 

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public int GetScore() => _score;

    public int GetLevel()
    {
        return _score/1000 +1;
    }
    // Default constructor so I can call it without any parameters in main
    public GoalManager() : this(new List<Goal>(), 0) { }

//subtracts the modulus of 1000 by score from 1000 to give the user the amount of points they still need
    public int GetPointsToNextLevel()
    {
        return 1000 - (_score % 1000);
    }

// Shows the player their score, level and how far to the next level
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"The player has {_score} points is at level {GetLevel()}, and needs {GetPointsToNextLevel()} points to level up)");

    }
    
    //goes through the list of goals and prints them for the user to see.
    public void ListGoalDetails()
    {
        Console.WriteLine("_________________Goal Details_____________________");
        foreach(Goal item in _goals) Console.WriteLine(item);
        Console.WriteLine("__________________________________________________");
    }

//Adds the points earned to the total score and returns the number of points earned.
    public int RecordEvent(int goalIndex)
    {
        int pointsEarned = _goals[goalIndex].RecordEvent();
        _score += pointsEarned;
        return pointsEarned;
    }

    public void SetData(int score, List<Goal> goals)
    {
        _score = score;
        _goals = goals;
    }
}