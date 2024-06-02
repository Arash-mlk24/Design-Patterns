namespace DesignPatterns.Sections.Creational.FactoryMethod;

public class XLogger : Logger
{
    public override void Log(string message)
    {
        Console.WriteLine($"XLogger: {message}");
    }
}