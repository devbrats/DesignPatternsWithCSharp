using System;

namespace DesignPatterns.Adapter_Pattern
{
    /// <summary>
    /// Pin based mobile charger.
    /// </summary>
    public class PinCharger
    {
        public void ChargeThroughPin()
        {
            Console.WriteLine("Using Pin Charger...");
            Console.WriteLine("Charging...");
        }
    }
}