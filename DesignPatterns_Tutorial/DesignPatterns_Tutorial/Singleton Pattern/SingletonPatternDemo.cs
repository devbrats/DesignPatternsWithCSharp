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
            SingletonImplementationVariationOne.Instance.Show();
            SingletonImplementationVariationTwo.Instance.Show();
            SingletonThreadSafeImplementation.Instance.Show();
        }
    }
}