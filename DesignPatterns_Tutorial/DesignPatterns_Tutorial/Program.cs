using System;
using DesignPatterns_Tutorial.Adapter_Pattern;
using DesignPatterns_Tutorial.Builder_Pattern;
using DesignPatterns_Tutorial.Singleton_Pattern;

namespace DesignPatterns_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo demo = new SingletonPatternDemo();
            //demo.Show();
            //var demo = new BuilderPatternDemo();
            //demo.Show();
            var demo = new AdapterPatternDemo();
            demo.Show();

        }
    }

}
