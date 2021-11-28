using System;

namespace ShipmentStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new ShippingCostCalculatorService();
            var order = new Order("Oradea","Cluj", ShippingMethod.FedEx);

            double cost = calculator.CalculateShippingCost(order);
            Console.WriteLine(cost);
            Console.ReadLine();

        }
    }
}
