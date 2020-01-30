using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
            double price = 0;
            switch (city)
            {
                case "Sofia":
                    switch (product)
                    {
                        case "coffee":
                             price = qty*0.50;
                            Console.WriteLine(price);
                            break;
                        case "water":
                             price = qty*0.80;
                            Console.WriteLine(price);

                            break;
                        case "beer":
                             price = qty*1.20;
                            Console.WriteLine(price);

                            break;
                        case "sweets":
                             price = qty*1.45;
                            Console.WriteLine(price);

                            break;
                        case "peanuts":
                             price = qty*1.60;
                            Console.WriteLine(price);
                            break;
                    }
                    break;
                case "Plovdiv":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.40;
                            Console.WriteLine(price * qty);

                            break;
                        case "water":
                            price = 0.70;
                            Console.WriteLine(price * qty);

                            break;
                        case "beer":
                            price = 1.15;
                            Console.WriteLine(price * qty);

                            break;
                        case "sweets":
                            price = 1.30;
                            Console.WriteLine(price * qty);

                            break;
                        case "peanuts":
                            price = 1.50;
                            Console.WriteLine(price * qty);

                            break;
                    }

                    break;
                case "Varna":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.45;
                            Console.WriteLine(price * qty);

                            break;
                        case "water":
                            price = 0.70;
                            Console.WriteLine(price * qty);

                            break;
                        case "beer":
                            price = 1.10;
                            Console.WriteLine(price * qty);

                            break;
                        case "sweets":
                            price = 1.35;
                            Console.WriteLine(price * qty);

                            break;
                        case "peanuts":
                            price = 1.55;
                            Console.WriteLine(price * qty);

                            break;
                    }
                    break;
            }
        }
    }
}
