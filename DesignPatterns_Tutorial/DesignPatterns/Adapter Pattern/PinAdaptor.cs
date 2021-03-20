using System;

namespace DesignPatterns.Adapter_Pattern
{
    public class PinAdaptor : IChargeAdaptor
    {
        private readonly PinCharger _pinCharger;

        public PinAdaptor(PinCharger pinCharger)
        {
            Console.WriteLine("Pin adaptor is created.");
            _pinCharger = pinCharger;
        }

        public void ChargeMobile()
        {
            _pinCharger.ChargeThroughPin();
        }
    }
}