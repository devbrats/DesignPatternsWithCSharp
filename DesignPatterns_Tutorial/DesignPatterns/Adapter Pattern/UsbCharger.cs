using System;

namespace DesignPatterns.Adapter_Pattern
{
    public class UsbCharger
    {
        public void Charge()
        {
            Console.WriteLine("Using USB Charger...");
            Console.WriteLine("Charging...");
        }
    }
}