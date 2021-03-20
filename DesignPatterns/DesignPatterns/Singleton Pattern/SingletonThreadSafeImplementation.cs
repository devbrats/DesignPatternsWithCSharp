using System;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton_Pattern
{
    public class SingletonThreadSafeImplementation
    {
        private static object _threadLock = new object();

        private static SingletonThreadSafeImplementation _instance;
        public static SingletonThreadSafeImplementation Instance
        {
            get
            {
                lock (_threadLock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonThreadSafeImplementation();
                    }

                    return _instance;
                }
            }
        }

        public string PatternName { get; set; }
        public string PatternType { get; set; }

        private SingletonThreadSafeImplementation()
        {
            PatternName = "Singleton Thread Safe Implementation";
            PatternType = "Creational";
        }

        public void Show()
        {
            Console.WriteLine("Singleton Thread Safe Implementation:");
            FirstThreadTask();
            SecondThreadTask();
            Task.Delay(1000);
        }

        private async void FirstThreadTask()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("First Thread");
                Console.WriteLine("Thread Id: " + Task.CurrentId);
                Console.WriteLine("Pattern Name: " + PatternName);
                Console.WriteLine("Pattern Type: " + PatternType);
                PatternType = "Test";
                Console.WriteLine("Instance Details: " + Instance.GetHashCode());
                Console.WriteLine("************************************************");
            });
        }

        private void SecondThreadTask()
        {
            Console.WriteLine("Second Thread");
            Console.WriteLine("Pattern Name: " + PatternName);
            Console.WriteLine("Pattern Type: " + PatternType);
            Console.WriteLine("Instance Details: " + Instance.GetHashCode());
            Console.WriteLine("************************************************");
        }
    }
}