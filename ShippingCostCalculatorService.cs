using System;

namespace ShipmentStrategy
{
    class ShippingCostCalculatorService
    {
        public double CalculateShippingCost(Order order)
        {
            // just returning some default values
            switch (order.ShippingMethod)
            {
                case ShippingMethod.FedEx:
                    return CalculateForFedEx(order);

                case ShippingMethod.UPS:
                    return CalculateForUPS(order);

                case ShippingMethod.USPS:
                    return CalculateForUSPS(order);

                default:
                    throw new Exception("unsupported shipping method");
            }
        }

        double CalculateForUSPS(Order order)
        {
            return 3.00d;
        }

        double CalculateForUPS(Order order)
        {
            return 4.25d;
        }

        double CalculateForFedEx(Order order)
        {
            return 5.00d;
        }

    }
}
