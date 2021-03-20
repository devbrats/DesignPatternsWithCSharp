using System;

namespace DesignPatterns.Builder_Pattern
{
    public  class TeaBuilder
    {
        private readonly Tea _tea;

        public TeaBuilder()
        {
            _tea =  new Tea();
        }

        public Tea PrepareTea()
        {
            _tea.AddIngredient("Water");
            _tea.AddIngredient("Milk");
            _tea.AddIngredient("Tea Leaf");
            _tea.AddIngredient("Sugar");
            Console.WriteLine("Tea is prepared !");
            return _tea;
        }
    }
}