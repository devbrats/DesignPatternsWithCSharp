namespace DesignPatterns_Tutorial.Adapter_Pattern
{
    public class AdapterPatternDemo : Demo
    {
        public override void Show()
        {
            var usbAdaptor = new UsbAdaptor(new UsbCharger());
            var pinAdaptor = new PinAdaptor(new PinCharger());
            var mobile = new Mobile(pinAdaptor);
            mobile.Charge();
        }
    }
}