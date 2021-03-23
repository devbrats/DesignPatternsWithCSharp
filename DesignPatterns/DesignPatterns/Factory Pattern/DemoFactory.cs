using System;
using DesignPatterns.Adapter_Pattern;
using DesignPatterns.Builder_Pattern;
using DesignPatterns.Mediator_Pattern;
using DesignPatterns.Observer_Pattern;
using DesignPatterns.Singleton_Pattern;

namespace DesignPatterns.Factory_Pattern
{
    /// <summary>
    /// Factory class to choose which demo user want to see.
    /// </summary>
    public class DemoFactory
    {
        public DesignPatternDemo GetDemo()
        {
            ShowDemoOptions();
            var demoChoice = int.Parse(Console.ReadLine());
            switch (demoChoice)
            {
                case 1:
                    return new AdapterPatternDemo();
                case 2:
                    return new BuilderPatternDemo();
                case 3:
                    return new MediatorPatternDemo();
                case 4:
                    return new SingletonPatternDemo();
                case 5:
                    return new ObserverPatternDemo();
                default:
                    return new FactoryPatternDemo();
            }
        }

        private void ShowDemoOptions()
        {
            Console.WriteLine("Available Demo:");
            Console.WriteLine("1. Adapter Pattern");
            Console.WriteLine("2. Builder Pattern");
            Console.WriteLine("3. Mediator Pattern");
            Console.WriteLine("4. Singleton Pattern");
            Console.WriteLine("5. Observer Pattern");
            Console.WriteLine("Others. Factory Pattern");
            Console.Write("Please Enter your choice for the demo type : ");
        }
    }
}