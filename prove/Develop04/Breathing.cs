using System;

public class Breathing : Activity
{

        // Initialized attributes
    private string _initialDisplay;

    private string _text = "";
    private bool _breatheIn = true;

    private int _countdown = 3;
    public Breathing()
    {
        // grab the text from the helper object once
        _initialDisplay = GetInitial();
    }

    /// Starts the breathing activity, displaying the initial message and then
    /// beginning the breathing loop which will continue until the activity duration
    /// has been reached.
    public void Run()
    {
        StartMessage(
            activityName: "Breathing Activity",
            description: _initialDisplay);

        // let each in/out last 7 seconds
        BreatheCountdown(countdown: 7);  

        BreatheLoop(_activityDuration);

        EndMessage("Breathing Activity");
    }

    private void BreatheLoop(int duration)
    {
        var end = DateTimeOffset.Now.AddSeconds(duration);
        bool breatheIn = true;

        while (DateTimeOffset.Now < end)
        {
            DisplayBreathe(breatheIn);
            breatheIn = !breatheIn;

            if (DateTimeOffset.Now.AddSeconds(4) > end)
            {
                // finish gently
                Console.Clear();
                break;
            }
        }
    }



   public string GetInitial()
    {
        return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }


    public void BreatheCountdown(int countdown)
    {
        _countdown = Math.Max(0, countdown);
    }

    public void DisplayBreathe(bool breatheIn)
    {
        Console.Clear();
        _breatheIn = breatheIn;
        _text = _breatheIn ? "Breathe in..." : "Breathe out... "; 
        Console.WriteLine(_text);
        Activity.Countdown(_countdown);
    
}}