using DesignPatterns.Base;

namespace DesignPatterns.Sections.Creational.FactoryMethod;

public class FactoryMethodSection : ISection
{
    private Logger _logger = null!;

    public void Run()
    {
        _logger = new XLogger();
        _logger.Log("a sample message!");

        _logger = new YLogger();
        _logger.Log("a sample message!");
    }
}