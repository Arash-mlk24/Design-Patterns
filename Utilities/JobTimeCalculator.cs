namespace DesignPatterns.Utilities;

public class JobTimeCalculator
{
    public static TimeSpan Calculate(Action job)
    {
        var startTime = DateTime.Now;
        job.Invoke();
        var endTime = DateTime.Now;
        return endTime - startTime;
    }
}