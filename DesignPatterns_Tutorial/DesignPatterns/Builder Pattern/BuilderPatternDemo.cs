using System;

namespace DesignPatterns.Builder_Pattern
{
    public class BuilderPatternDemo:DesignPatternDemo
    {
        public override void Show()
        {
            Console.WriteLine("***Builder Pattern Demo***");
            Console.WriteLine("Building tea adding different ingredients...");
            var teaBuilder = new TeaBuilder();
            var tea = teaBuilder.PrepareTea();
            tea.ServeTea();

            Console.WriteLine("*********************");
            Console.WriteLine("Building tea using fluent builder...");
            var teaUsingFluentBuilder = new FluentTeaBuilder()
                .AddWater()
                .AddMilk()
                .AddTeaLeaf()
                .AddSugar()
                .Boil()
                .GetTea();
            teaUsingFluentBuilder.ServeTea();
        }
    }
}
