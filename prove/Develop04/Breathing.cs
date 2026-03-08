using System;

public class Breathing : Activity
{
    private string _initialDisplay;
    private readonly Breathe _breathe = new();

    public Breathing()
    {
        // grab the text from the helper object once
        _initialDisplay = _breathe.GetInitial();
    }

    // entry point for the activity – not a constructor
    public void Run()
    {
        StartMessage(
            activityName: "Breathing Activity",
            description: _initialDisplay);

        // let each in/out last 4 seconds
        _breathe.BreatheCountdown(countdown: 4);  

        BreatheLoop(_activityDuration);

        EndMessage("Breathing Activity");
    }

    private void BreatheLoop(int duration)
    {
        var end = DateTimeOffset.Now.AddSeconds(duration);
        bool breatheIn = true;

        while (DateTimeOffset.Now < end)
        {
            _breathe.DisplayBreathe(breatheIn);
            breatheIn = !breatheIn;

            if (DateTimeOffset.Now.AddSeconds(4) > end)
            {
                // finish gently
                break;
            }
        }
    }
}