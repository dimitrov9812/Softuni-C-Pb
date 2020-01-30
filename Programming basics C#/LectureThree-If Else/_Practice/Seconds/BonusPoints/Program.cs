using System;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());
            double fistBonus = 5;
            double secondBonus = number*0.2;
            double thirdBonus =  number*0.1;
            double overallBonus = 0;

            if (number <= 100)
            {
                if (number % 2 == 0)
                {
                    overallBonus = fistBonus + 1;
                }
                else if (number % 10 == 5)
                {
                    overallBonus = fistBonus + 2;
                }
                else
                {
                    overallBonus = fistBonus;
                }
                Console.WriteLine(overallBonus);
                Console.WriteLine(overallBonus+number);
            }
            else if (number > 100 && number <= 1000)
            {
                if (number % 2 == 0)
                {
                    overallBonus = secondBonus + 1;
                }
                else if (number % 10 == 5)
                {
                    overallBonus = secondBonus + 2;
                }
                else
                {
                    overallBonus = secondBonus;
                }
                Console.WriteLine(overallBonus);
                Console.WriteLine(overallBonus + number);
            }
            else if (number > 1000)
            {
                if (number % 2 == 0)
                {
                    overallBonus = thirdBonus + 1;
                }
                else if (number % 10 == 5)
                {
                    overallBonus = thirdBonus + 2;
                }
                else
                {
                    overallBonus = thirdBonus;
                }
                Console.WriteLine(overallBonus);
                Console.WriteLine(overallBonus + number);
            }

        }
    }
}
