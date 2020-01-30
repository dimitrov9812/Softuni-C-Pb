using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());
            OrderValue(product, qty);
        }
        static void OrderValue(string product, int qty)
        {
            double coffeePrice = 1.50;
            double waterPrice = 1.00;
            double cokePrice = 1.40;
            double snacksPrice = 2.00;
            switch (product)
            {
                case "coffee":
                    Console.WriteLine("{0:f2}",qty*coffeePrice);
                    break;
                case "water":
                    Console.WriteLine("{0:f2}", qty * waterPrice);
                    break;
                case "coke":
                    Console.WriteLine("{0:f2}", qty * cokePrice);
                    break;
                case "snacks":
                    Console.WriteLine("{0:f2}", qty * snacksPrice);
                    break;
                default:
                    break;
            }
        }
    }
}
