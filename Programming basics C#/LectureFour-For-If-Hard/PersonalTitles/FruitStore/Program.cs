using System;

namespace FruitStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
            double price = 0;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.50 * qty;
                            Console.WriteLine("{0:F2}", price);
                            break;
                        case "apple":
                            price =  1.20* qty;
                            Console.WriteLine("{0:F2}", price);
                            break;
                        case "orange":
                            price = 0.85 * qty;
                            Console.WriteLine("{0:F2}", price);
                            break;
                        case "grapefruit":
                            price = 1.45 * qty;
                            Console.WriteLine("{0:F2}", price);
                            break;
                        case "kiwi":
                            price = 2.70 * qty;
                            Console.WriteLine("{0:F2}", price);
                            break;
                        case "pineapple":
                            price = 5.50 * qty;
                            Console.WriteLine("{0:F2}", price);
                            break;
                        case "grapes":
                            price = 3.85 * qty;
                            Console.WriteLine("{0:F2}",price);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;

                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.70 * qty;
                            Console.WriteLine("{0:F2}", price);
                            break;
                        case "apple":
                            price = 1.25 * qty;
                            Console.WriteLine("{0:F2}", price);
                            break;
                        case "orange":
                            price = 0.90 * qty;
                            Console.WriteLine("{0:F2}", price);
                            break;
                        case "grapefruit":
                            price = 1.60 * qty;
                            Console.WriteLine("{0:F2}", price);
                            break;
                        case "kiwi":
                            price = 3.00 * qty;
                            Console.WriteLine("{0:F2}", price);
                            break;
                        case "pineapple":
                            price = 5.60 * qty;
                            Console.WriteLine("{0:F2}", price);
                            break;
                        case "grapes":
                            price = 4.20 * qty;
                            Console.WriteLine("{0:F2}", price);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
