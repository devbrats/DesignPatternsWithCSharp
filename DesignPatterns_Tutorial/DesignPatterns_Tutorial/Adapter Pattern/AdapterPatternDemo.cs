namespace DesignPatterns_Tutorial.Adapter_Pattern
{
    public class AdapterPatternDemo : Demo
    {
        public override void Show()
        {
            var usbAdaptor = new UsbAdaptor(new UsbCharger());
            var mobile = new Mobile(usbAdaptor);
            mobile.Charge();
            var pinAdaptor = new PinAdaptor(new PinCharger());
            mobile = new Mobile(pinAdaptor);
            mobile.Charge();
        }
    }
}