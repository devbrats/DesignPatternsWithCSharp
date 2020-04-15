using System;
using DesignPatterns_Tutorial.Factory_Pattern;

namespace DesignPatterns_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new FactoryPatternDemo();
            demo.Show();
            Console.WriteLine("\nNote: To get the actual implementation details explore the Show() method and respective folders in the code.");

        }
    }

}
