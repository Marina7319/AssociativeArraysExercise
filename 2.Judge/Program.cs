using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = new Dictionary<string, double>();
            var newOrders = new Dictionary<string, double>();
            var input = Console.ReadLine();
            while (input != "buy")
            {
                var cmd = input.Split();
                var productName = cmd[0];
                double productPrice = double.Parse(cmd[1]);
                int quantity = int.Parse(cmd[2]);
                if (!orders.ContainsKey(productName))
                {
                    orders.Add(productName, productPrice);
                    newOrders.Add(productName, quantity);
                }
                else if (orders.ContainsKey(productName))
                {
                    orders.Remove(productName);
                    orders.Add(productName, productPrice);
                    newOrders[productName] += quantity;
                }
                input = Console.ReadLine();
            }
            foreach (var order in orders)
            {
                foreach (var newOrder in newOrders)
                {
                    if (order.Key == newOrder.Key)
                    {
                        Console.WriteLine($"{order.Key} -> {(newOrder.Value * order.Value):f2}");
                    }
                }
            }
        }
    }
}
