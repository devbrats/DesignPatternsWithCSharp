using System;

namespace DesignPatterns.Adapter_Pattern
{
    public class PinCharger
    {
        public void ChargeThroughPin()
        {
            Console.WriteLine("Using Pin Charger...");
            Console.WriteLine("Charging...");
        }
    }
}