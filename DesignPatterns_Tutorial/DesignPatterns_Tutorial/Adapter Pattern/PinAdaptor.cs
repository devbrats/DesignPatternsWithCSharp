namespace DesignPatterns_Tutorial.Adapter_Pattern
{
    public class PinAdaptor : IChargeAdaptor
    {
        private readonly PinCharger _pinCharger;

        public PinAdaptor(PinCharger pinCharger)
        {
            _pinCharger = pinCharger;
        }

        public void ChargeMobile()
        {
            _pinCharger.ChargeThroughPin();
        }
    }
}