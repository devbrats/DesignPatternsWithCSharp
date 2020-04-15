using System;
using System.Collections.Generic;

namespace DesignPatterns_Tutorial.Builder_Pattern
{
    public class Tea
    {
        private readonly List<string> _ingredients;

        public Tea()
        {
            _ingredients = new List<string>();
        }

        public void AddIngredient(string ingredient)
        {
            _ingredients.Add(ingredient);
        }

        public void ServeTea()
        {
            Console.WriteLine("Tea......");
            Console.WriteLine("****************");
            foreach (var ingredient in _ingredients)
            {
                Console.WriteLine(ingredient);
            }
            Console.WriteLine("****************");
        }
    }

}