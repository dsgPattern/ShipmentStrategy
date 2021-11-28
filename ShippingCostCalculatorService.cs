using System;
using System.Reflection.Metadata.Ecma335;

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

        double CalculateForFedEx(Order order)
        {
            const double maxFreeSize = 2;
            const double maxFreeWeight = 10;
            const double pricePerKg = 1;
            const double pricePerSquareMeter = 2;

            double total = 20;
            if (order.GetTotalWeight() > maxFreeWeight)
            {
                total += (order.GetTotalWeight() - maxFreeWeight) * pricePerKg;
            }

            if (order.GetTotalsize() > maxFreeSize)
            {
                total += (order.GetTotalsize() - maxFreeSize) * pricePerSquareMeter;
            }

            return total;
        }

        double CalculateForUSPS(Order order)
        {
            return 3.00d;
        }

        double CalculateForUPS(Order order)
        {
            return 4.25d;
        }


    }
}
