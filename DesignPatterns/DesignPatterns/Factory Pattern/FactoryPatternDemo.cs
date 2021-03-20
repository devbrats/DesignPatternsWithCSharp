namespace DesignPatterns.Factory_Pattern
{
    public class FactoryPatternDemo:DesignPatternDemo
    {
        public override void Show()
        {
           var demoFactory = new DemoFactory();
            var demo = demoFactory.GetDemo();
            demo.Show();
        }
    }
}