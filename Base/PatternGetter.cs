using DesignPatterns.Sections.Creational.FactoryMethod;
using DesignPatterns.Sections.Creational.Singleton;

namespace DesignPatterns.Base;

public static class PatternGetter
{
    public static CreationalPatternGetter GetCreationals()
    {
        return new CreationalPatternGetter();
    }
}

public class CreationalPatternGetter
{
    public ISection GetFactoryMethod()
    {
        return new FactoryMethodSection();
    }

    public ISection GetSingleton()
    {
        return new SingletonSection();
    }


}