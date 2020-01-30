using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());
            double shipPrice = 0;
            double moneyleft = 0;
            switch (season)
            {
                case "Spring":
                    shipPrice = 3000;
                    break;
                case "Summer":
                    shipPrice = 4200;
                    break;
                case "Autumn":
                    shipPrice = 4200;
                    break;
                case "Winter":
                    shipPrice = 2600;
                    break;
            }
            if(fishermans <= 6)
            {
                if (fishermans % 2 == 0 && season != "Autumn")
                {
                    shipPrice = shipPrice - (shipPrice * 0.15);
                }
                else
                {
                    shipPrice = shipPrice - (shipPrice * 0.10);
                }
            }
            else if(fishermans>=7 && fishermans <= 11)
            {
                if (fishermans % 2 == 0 && season != "Autumn")
                {
                    shipPrice = shipPrice - (shipPrice * 0.20);
                }
                else
                {
                    shipPrice = shipPrice - (shipPrice * 0.15);
                }
            }
            else if (fishermans >= 12)
            {
                if (fishermans % 2 == 0 && season != "Autumn")
                {
                    shipPrice = shipPrice - (shipPrice * 0.30);
                }
                else
                {
                    shipPrice = shipPrice - (shipPrice * 0.25);               
                }
                
            }

            if(budget > shipPrice)
            {
                moneyleft = budget - shipPrice;
                Console.WriteLine("Yes! You have {0:f2} leva left.",moneyleft);
            }
            else
            {
                moneyleft = shipPrice - budget;
                Console.WriteLine("Not enough money! You need {0:f2} leva.",moneyleft);
                    
            }
        }
    }
}
