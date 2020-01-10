using System;
using System.Threading;

namespace DesignPatterns_Tutorial.Singleton_Pattern
{
    public class SingletonPatternDemo : Demo
    {
        public override void Show()
        {
            Console.WriteLine("Singleton Pattern: ");
            Console.WriteLine();
            SingletonImplementation_1.Instance.Show();
            SingletonImplementation_2.Instance.Show();
            SingletonThreadSafeImplementation.Instance.Show();
        }
    }
}