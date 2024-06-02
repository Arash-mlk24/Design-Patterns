namespace DesignPatterns.Sections.Creational.Singleton;

public class SingletonDatabase
{
    private static SingletonDatabase? Instance;

    public static SingletonDatabase GetInstance()
    {
        Instance ??= new SingletonDatabase();
        return Instance;
    }

    private SingletonDatabase()
    {
        Task.Delay(3000).GetAwaiter().GetResult();
    }
}