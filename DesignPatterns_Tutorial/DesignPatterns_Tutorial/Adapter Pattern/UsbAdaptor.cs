using System;

namespace DesignPatterns_Tutorial.Adapter_Pattern
{
    public class UsbAdaptor : IChargeAdaptor
    {
        private readonly UsbCharger _usbCharger;

        public UsbAdaptor(UsbCharger usbCharger)
        {
            Console.WriteLine("Usb adaptor is created.");
            _usbCharger = usbCharger;
        }

        public void ChargeMobile()
        {
            _usbCharger.Charge();
        }
    }
}