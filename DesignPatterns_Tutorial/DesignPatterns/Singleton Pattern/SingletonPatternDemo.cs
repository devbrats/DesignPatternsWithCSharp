using System;
using System.Threading;

namespace DesignPatterns.Singleton_Pattern
{
    public class SingletonPatternDemo : DesignPatternDemo
    {
        public override void Show()
        {
            Console.WriteLine("Singleton Pattern: ");
            Console.WriteLine();
            SingletonImplementationVariationOne.Instance.Show();
            SingletonImplementationVariationTwo.Instance.Show();
            SingletonThreadSafeImplementation.Instance.Show();
        }
    }
}