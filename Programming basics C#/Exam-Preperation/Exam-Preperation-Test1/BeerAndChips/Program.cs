using System;

namespace BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            double beerCount = double.Parse(Console.ReadLine());
            double chipsCount = double.Parse(Console.ReadLine());
            double beerPrice = 1.20;
            double oneChipsPrice = (0.45 * (beerCount * beerPrice));
            double fullChipsPrice = Math.Ceiling(chipsCount * oneChipsPrice);

            double finalPrice = fullChipsPrice + beerPrice*beerCount;
            if (finalPrice <= budget)
            {
                Console.WriteLine("{0} bought a snack and has {1:F2} leva left.",name,budget-finalPrice);
            }
            else
            {
                Console.WriteLine("{0} needs {1:F2} more leva!",name,finalPrice-budget);
            }
        }
    }
}
