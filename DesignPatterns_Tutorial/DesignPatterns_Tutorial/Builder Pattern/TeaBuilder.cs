using System;

namespace DesignPatterns_Tutorial.Builder_Pattern
{
    public static class TeaBuilder
    {
        public static Tea PreapareTea()
        {
            return new Tea();
        }

        public static Tea AddMilk(this Tea tea)
        {
            Console.WriteLine("Milk is added.");
            return tea;
        }

        public static Tea AddWater(this Tea tea)
        {
            Console.WriteLine("Water is added.");
            return tea;
        }
        public static Tea AddTeaLeaf(this Tea tea)
        {
            Console.WriteLine("TeaLeaf is added.");
            return tea;
        }
        public static Tea AddSugar(this Tea tea)
        {
            Console.WriteLine("Sugar is added.");
            return tea;
        }

        public static Tea Boil(this Tea tea)
        {
            Console.WriteLine("Tea is prepared !");
            return tea;
        }
    }
}