namespace ShipmentStrategy
{
    class Order
    {
        private string _destination;
        private string _origin;
        private ShippingMethod _shippingMethod;

        public ShippingMethod ShippingMethod => _shippingMethod;

        public Order(string origin, string destionation, ShippingMethod shippingMethod)
        {
            _destination = destionation;
            _origin = origin;
            _shippingMethod = shippingMethod;
        }
       
    }
}
