using System;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double startMoney = money;
            double outFallPrice = 39.99;
            double csPrice = 15.99;
            double zplinterPrice = 19.99;
            double honoredPrice = 59.99;
            double roverWatchPrice = 29.99;
            double roverWatchOriginsPrice = 39.99;
            string input;
            double totalSpent = 0;          
            do
            {
                 input = Console.ReadLine();
                switch (input)
                {
                    case "OutFall 4":
                        if (money >= outFallPrice)
                        {
                            Console.WriteLine("Bought OutFall 4");
                            money -= outFallPrice;
                            totalSpent += outFallPrice;
                        }
                        else if(money == 0)
                        {
                            Console.WriteLine("Out of money!");
                        }
                        else 
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS:OG":
                        if (money >= csPrice)
                        {
                            Console.WriteLine("Bought CS:OG");
                            money -= csPrice;
                            totalSpent += csPrice;
                        }
                        else if (money == 0)
                        {
                            Console.WriteLine("Out of money!");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (money >= zplinterPrice)
                        {
                            Console.WriteLine("Bought Zplinter Zell");
                            money -= zplinterPrice;
                            totalSpent += zplinterPrice;
                        }
                        else if (money == 0)
                        {
                            Console.WriteLine("Out of money!");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (money >= honoredPrice)
                        {
                            Console.WriteLine("Bought Honored 2");
                            money -= honoredPrice;
                            totalSpent += honoredPrice;
                        }
                        else if (money == 0)
                        {
                            Console.WriteLine("Out of money!");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (money >= roverWatchPrice)
                        {
                            Console.WriteLine("Bought RoverWatch");
                            money -= roverWatchPrice;
                            totalSpent += roverWatchPrice;
                        }
                        else if (money == 0)
                        {
                            Console.WriteLine("Out of money!");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (money >= roverWatchOriginsPrice)
                        {
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                            money -= roverWatchPrice;
                            totalSpent += roverWatchOriginsPrice;
                        }
                        else if (money == 0)
                        {
                            Console.WriteLine("Out of money!");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        if(input == "Game Time")
                        {
                            continue;
                        }
                        else { 
                        Console.WriteLine("Not Found");
                            }
                        break;
                }
            } while (input != "Game Time");
            double moneyLeft = startMoney - totalSpent;
            if(money == 0)
            {
                Console.WriteLine("Out of money!");
            }
            Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}",totalSpent,moneyLeft);

        }
    }
}
