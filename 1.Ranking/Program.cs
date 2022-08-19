using System;
using System.Collections.Generic;
namespace AMinnerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Dictionary<string, int>();
            string resources = Console.ReadLine();
            while (resources != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!items.ContainsKey(resources))
                {
                    items.Add(resources, 0);
                }
                items[resources] += quantity;
                resources = Console.ReadLine();
            }
            foreach (var carResources in items)
            {
                Console.WriteLine($"{carResources.Key} -> {carResources.Value}");
            }
        }
    }
}
