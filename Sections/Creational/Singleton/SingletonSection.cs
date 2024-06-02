using DesignPatterns.Base;
using DesignPatterns.Utilities;

namespace DesignPatterns.Sections.Creational.Singleton;

public class SingletonSection : ISection
{
    public void Run()
    {
        Console.WriteLine("Getting non-singleton database instance for 3 times...");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"attempt number {i + 1}:");
            var time = JobTimeCalculator.Calculate(InitializeNonSingletonDatabase);
            Console.WriteLine($"time passed (in milliseconds): {time.TotalMilliseconds}");
        }

        Console.WriteLine("\nGetting singleton database instance for 3 times...");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"attempt number {i + 1}:");
            var time = JobTimeCalculator.Calculate(InitializeSingletonDatabase);
            Console.WriteLine($"time passed (in milliseconds): {time.TotalMilliseconds}");
        }
    }

    private static void InitializeNonSingletonDatabase()
    {
        var _ = new NonSingletonDatabase();
    }

    private static void InitializeSingletonDatabase()
    {
        var _ = SingletonDatabase.GetInstance();
    }
}