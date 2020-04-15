using DesignPatterns_Tutorial.Mediator_Pattern;

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
//            var demo = new AdapterPatternDemo();
//            demo.Show();
            var mediatorDemo = new MediatorDemo();
            mediatorDemo.ShowDemo();

        }
    }

}
