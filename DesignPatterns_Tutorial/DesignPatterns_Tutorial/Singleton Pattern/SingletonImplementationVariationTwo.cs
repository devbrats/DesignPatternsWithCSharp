using System;

namespace DesignPatterns_Tutorial.Singleton_Pattern
{
    public class SingletonImplementationVariationTwo
    {
        private static SingletonImplementationVariationTwo _instance;
        public static SingletonImplementationVariationTwo Instance => _instance ?? (_instance = new SingletonImplementationVariationTwo());

        public string PatternName { get; set; }
        public string PatternType { get; set; }

        private SingletonImplementationVariationTwo()
        {
            PatternName = "SingletonImplementationVariationTwo";
            PatternType = "Creational";
        }

        public void Show()
        {
            Console.WriteLine("Singleton Implementation Two:");
            Console.WriteLine("Pattern Name: "+PatternName);
            Console.WriteLine("Pattern Type: "+PatternType);
            Console.WriteLine("Instance Details: "+Instance.GetHashCode());
            Console.WriteLine("************************************************");

        }
    }
}