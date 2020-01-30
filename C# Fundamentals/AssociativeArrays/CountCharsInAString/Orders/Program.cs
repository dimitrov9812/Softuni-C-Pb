using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Dictionary<string, double[]>();
            string input;
            while ((input = Console.ReadLine())!= "buy")
            {
                var splittedInput = input.Split(' ').ToList();
                var name = splittedInput[0];
                var price = double.Parse(splittedInput[1]);
                var qty = double.Parse(splittedInput[2]);

                if (!inventory.ContainsKey(name))
                {

                    inventory.Add(name, new double[2]);
                }
                inventory[name][0] = price;
                inventory[name][1] += qty;

            }
            foreach (var kvp in inventory)
            {
                Console.WriteLine($"{kvp.Key} -> {(kvp.Value[0]*kvp.Value[1]):F2}");
            }
        }
    }
}
