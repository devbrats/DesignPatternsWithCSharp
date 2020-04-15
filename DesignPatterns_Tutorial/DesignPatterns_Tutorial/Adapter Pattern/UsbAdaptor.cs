namespace DesignPatterns_Tutorial.Adapter_Pattern
{
    public class UsbAdaptor : IChargeAdaptor
    {
        private readonly UsbCharger _usbCharger;

        public UsbAdaptor(UsbCharger usbCharger)
        {
            _usbCharger = usbCharger;
        }

        public void ChargeMobile()
        {
            _usbCharger.Charge();
        }
    }
}