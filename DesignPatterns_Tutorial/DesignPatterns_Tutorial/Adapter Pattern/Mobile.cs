namespace DesignPatterns_Tutorial.Adapter_Pattern
{
    public class Mobile
    {
        public IAdaptor Adaptor { get; set; }

        public Mobile(IAdaptor adaptor)
        {
            Adaptor = adaptor;
        }

        public void Charge()
        {
            Adaptor.ChargeMobile();
        }
    }
}