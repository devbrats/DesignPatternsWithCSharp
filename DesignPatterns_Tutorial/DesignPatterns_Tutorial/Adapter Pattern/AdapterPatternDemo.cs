﻿using System;

namespace DesignPatterns_Tutorial.Adapter_Pattern
{
    public class AdapterPatternDemo : DesignPatternDemo
    {
        public override void Show()
        {
            Console.WriteLine("Adapter pattern demo.");
            Console.WriteLine("Mobile to adapt different chargers...");
            var usbAdaptor = new UsbAdaptor(new UsbCharger());
            var mobile = new Mobile(usbAdaptor);
            mobile.Charge();
            var pinAdaptor = new PinAdaptor(new PinCharger());
            mobile = new Mobile(pinAdaptor);
            mobile.Charge();
        }
    }
}