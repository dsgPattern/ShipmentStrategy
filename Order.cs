using System.Collections.Generic;
using System.Linq;

namespace ShipmentStrategy
{
    class Order
    {
        private string _destination;
        private string _origin;
        private ShippingMethod _shippingMethod;
        private List<Product> _products = new List<Product>();

        public ShippingMethod ShippingMethod => _shippingMethod;
       
        public Order(string origin, string destionation, ShippingMethod shippingMethod)
        {
            _destination = destionation;
            _origin = origin;
            _shippingMethod = shippingMethod;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double GetTotalWeight()
        {
            return _products.Sum(x => x.Weight);
        }

        public double GetTotalsize()
        {
            return _products.Sum(x => x.Size);
        }
    }
}
