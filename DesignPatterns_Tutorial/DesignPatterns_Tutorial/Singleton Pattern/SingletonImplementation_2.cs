using System;

namespace DesignPatterns_Tutorial.Singleton_Pattern
{
    public class SingletonImplementation_2
    {
        private static SingletonImplementation_2 _instance;
        public static SingletonImplementation_2 Instance => _instance ?? (_instance = new SingletonImplementation_2());

        public string PatternName { get; set; }
        public string PatternType { get; set; }

        private SingletonImplementation_2()
        {
            PatternName = "SingletonImplementation_2";
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