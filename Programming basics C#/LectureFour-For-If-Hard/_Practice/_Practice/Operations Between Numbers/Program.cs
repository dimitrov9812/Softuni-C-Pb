using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double sparedMoney = 0;
            string whereToSleep = "";
            string destination = "";
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    sparedMoney = budget * 0.30;
                    whereToSleep = "Camp";
                    destination = "Bulgaria";
                    Console.WriteLine("Somewhere in {0}", destination);
                    Console.WriteLine("{0} - {1:f2}", whereToSleep, sparedMoney);
                }
                else
                {
                    sparedMoney = budget * 0.70;
                    whereToSleep = "Hotel";
                    destination = "Bulgaria";
                    Console.WriteLine("Somewhere in {0}", destination);
                    Console.WriteLine("{0} - {1:f2}", whereToSleep, sparedMoney);
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    sparedMoney = budget * 0.40;
                    whereToSleep = "Camp";
                    destination = "Balkans";
                    Console.WriteLine("Somewhere in {0}", destination);
                    Console.WriteLine("{0} - {1:f2}", whereToSleep, sparedMoney);
                }
                else
                {
                    sparedMoney = budget * 0.80;
                    whereToSleep = "Hotel";
                    destination = "Balkans";
                    Console.WriteLine("Somewhere in {0}", destination);
                    Console.WriteLine("{0} - {1:f2}", whereToSleep, sparedMoney);
                }
            }
            else if (budget > 1000)
            {
                sparedMoney = budget * 0.90;
                whereToSleep = "Hotel";
                destination = "Europe";
                Console.WriteLine("Somewhere in {0}", destination);
                Console.WriteLine("{0} - {1:f2}", whereToSleep, sparedMoney);

            }
        }
    }
}
