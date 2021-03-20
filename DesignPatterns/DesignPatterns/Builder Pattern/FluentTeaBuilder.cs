using System;

namespace DesignPatterns.Builder_Pattern
{
    public class FluentTeaBuilder
    {
        private readonly Tea _tea;

        public FluentTeaBuilder()
        {
            _tea = new Tea();
        }

        public Tea GetTea()
        {
            return _tea;
        }

        public FluentTeaBuilder AddWater()
        {
            _tea.AddIngredient("Water");
            return this;
        }

        public FluentTeaBuilder AddMilk()
        {
            _tea.AddIngredient("Milk");
            return this;
        }

        public FluentTeaBuilder AddTeaLeaf()
        {
            _tea.AddIngredient("Tea Leaf");
            return this;
        }

        public FluentTeaBuilder AddSugar()
        {
            _tea.AddIngredient("Sugar");
            return this;
        }

        public FluentTeaBuilder Boil()
        {
            Console.WriteLine("Tea is prepared !");
            return this;
        }
    }
}