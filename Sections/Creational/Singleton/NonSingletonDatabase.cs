namespace DesignPatterns.Sections.Creational.Singleton;

public class NonSingletonDatabase
{
    public NonSingletonDatabase()
    {
        Task.Delay(3000).GetAwaiter().GetResult();
    }
}