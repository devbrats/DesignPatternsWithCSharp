using System;

namespace DesignPatterns_Tutorial.Adapter_Pattern
{
    public class UsbCharger
    {
        public void Charge()
        {
            Console.WriteLine("Using USB Charger...");
            Console.WriteLine("Charging...");
        }
    }

    public class PinCharger
    {
        public void ChargeThroughPin()
        {
            Console.WriteLine("Using Pin Charger...");
            Console.WriteLine("Charging...");
        }
    }
}