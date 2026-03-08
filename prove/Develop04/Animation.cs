
public class Animation()
{
    private static char[] _spin = new[] {'|', '/', '-', '\\'};

    public static void Spinner(int seconds)
    {
        var end = DateTimeOffset.Now.AddSeconds(seconds);
        int i = 0; 
        while (DateTimeOffset.Now > end)
        {
            Console.Write($"\r{_spin[i % _spin.Length]} ");
            Thread.Sleep(60); 
            i ++; 
        }
        Console.Write("\r \r"); 
    }

    public static void Countdown(int seconds)
    {
        for(int s = seconds; s >= 1; s--)
        {
            Console.Write(s);
            Thread.Sleep(10);
        }
    }
}
        
   