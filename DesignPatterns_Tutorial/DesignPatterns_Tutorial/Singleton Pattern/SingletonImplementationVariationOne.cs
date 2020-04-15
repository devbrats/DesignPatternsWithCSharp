using System;

namespace DesignPatterns_Tutorial.Singleton_Pattern
{
    public class SingletonImplementationVariationOne
    {
        public static SingletonImplementationVariationOne Instance { get; set; } = new SingletonImplementationVariationOne();

        public string PatternName { get; set; }
        public string PatternType { get; set; }

        private SingletonImplementationVariationOne()
        {
            PatternName = "SingletonImplementationVariationOne";
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