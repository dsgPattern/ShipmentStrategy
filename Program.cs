using System;

namespace ShipmentStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new ShippingCostCalculatorService();
            var order = new Order("Oradea", "Cluj", ShippingMethod.FedEx);
            order.AddProduct(new Product { Name = "Laptop", Size = 0.2 * 0.15 * 0.02, Weight = 3 });
            order.AddProduct(new Product { Name = "Masina de spalat", Size = 0.8 * 0.4 * 0.3, Weight = 10 });


            double cost = calculator.CalculateShippingCost(order);
            Console.WriteLine(cost);
            Console.ReadLine();

        }
    }
}
