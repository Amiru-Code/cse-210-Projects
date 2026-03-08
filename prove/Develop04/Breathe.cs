
public class Breathe
{
    // Initialized attributes
    private string _text = "";
    private bool _breatheIn = true;
    private int _countdown = 4;


   public string GetInitial()
    {
    return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }


    public void BreatheCountdown(int countdown)
    {
        _countdown = Math.Max(1, countdown);
    }

    public void DisplayBreathe(bool breatheIn)
    {
        Console.Clear();
        _breatheIn = breatheIn;
        _text = _breatheIn ? "Breathe in..." : "Breathe out... "; 
        Console.WriteLine(_text);
        Animation.Countdown(_countdown);
    }
}