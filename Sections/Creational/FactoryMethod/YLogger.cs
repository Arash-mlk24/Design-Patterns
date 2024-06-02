namespace DesignPatterns.Sections.Creational.FactoryMethod;

public class YLogger : Logger
{
    public override void Log(string message)
    {
        Console.WriteLine($"YLogger: {message}");
    }
}