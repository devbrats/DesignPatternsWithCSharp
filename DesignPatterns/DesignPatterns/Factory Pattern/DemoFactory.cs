using System;
using DesignPatterns.Adapter_Pattern;
using DesignPatterns.Builder_Pattern;
using DesignPatterns.Mediator_Pattern;
using DesignPatterns.Singleton_Pattern;

namespace DesignPatterns.Factory_Pattern
{
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
                default:
                    return new FactoryPatternDemo();
            }
        }

        private void ShowDemoOptions()
        {
            Console.WriteLine("Available Demo:");
            Console.WriteLine("1. Adapter Pattern");
            Console.WriteLine("2. Builder Pattern");
            Console.WriteLine("2. MediatorPattern");
            Console.WriteLine("2. SingletonPattern");
            Console.Write("Please Enter your choice for the demo type : ");
        }
    }
}