namespace DesignPatterns_Tutorial.Adapter_Pattern
{
    public interface IAdaptor
    {
        void ChargeMobile();
    }

    public class UsbAdaptor : IAdaptor
    {
        private UsbCharger _usbCharger;

        public UsbAdaptor(UsbCharger usbCharger)
        {
            _usbCharger = usbCharger;
        }

        public void ChargeMobile()
        {
            _usbCharger.Charge();
        }
    }

    public class PinAdaptor : IAdaptor
    {
        private PinCharger _pinCharger;
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