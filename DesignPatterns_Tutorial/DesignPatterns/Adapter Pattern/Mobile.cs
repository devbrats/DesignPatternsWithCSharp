namespace DesignPatterns.Adapter_Pattern
{
    public class Mobile
    {
        public IChargeAdaptor ChargeAdaptor { get; set; }

        public Mobile(IChargeAdaptor chargeAdaptor)
        {
            ChargeAdaptor = chargeAdaptor;
        }

        public void Charge()
        {
            ChargeAdaptor.ChargeMobile();
        }
    }
}