using System;

namespace DesignPatterns.Adapter_Pattern
{
    /// <summary>
    /// Usb based mobile Charger.
    /// </summary>
    public class UsbCharger
    {
        public void Charge()
        {
            Console.WriteLine("Using USB Charger...");
            Console.WriteLine("Charging...");
        }
    }
}