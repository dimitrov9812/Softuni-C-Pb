using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());           
            int moneySpared = 0;
            
            for (int i = 0; i <number; i++)
            {
                string item = Console.ReadLine();
                if (item == "hoodie")
                {
                    moneySpared += 30;
                }
                else if (item == "keychain")
                {
                    moneySpared += 4;
                }
                else if (item == "T-shirt")
                {
                    moneySpared += 20;
                }
                else if (item == "flag")
                {
                    moneySpared += 15;
                }
                else if (item == "sticker")
                {
                    moneySpared += 1;
                }
            }
            if (moneySpared <= budget)
            {
                Console.WriteLine("You bought {0} items and left with {1} lv.", number, budget - moneySpared);
            }
            else
            {
                Console.WriteLine("Not enough money, you need {0} more lv.", moneySpared - budget);
            }
        }
    }
}
