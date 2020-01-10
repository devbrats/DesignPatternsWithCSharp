using System;

namespace DesignPatterns_Tutorial.Singleton_Pattern
{
    public class SingletonImplementation_1
    {
        public static SingletonImplementation_1 Instance { get; set; } = new SingletonImplementation_1();

        public string PatternName { get; set; }
        public string PatternType { get; set; }

        private SingletonImplementation_1()
        {
            PatternName = "SingletonImplementation_1";
            PatternType = "Creational";
        }

        public void Show()
        {
            Console.WriteLine("Singleton Implementation One:");
            Console.WriteLine("Pattern Name: " + PatternName);
            Console.WriteLine("Pattern Type: " + PatternType);
            Console.WriteLine("Instance Details: " + Instance.GetHashCode());
            Console.WriteLine("************************************************");
        }
    }
}