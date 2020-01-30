using System;

namespace Exam_Preperation_Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            double fullIncome;
            double charityMoney;
            int numberOfSectors = int.Parse(Console.ReadLine());
            int staduimCapacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            fullIncome = (staduimCapacity * ticketPrice);
            double onePartIncome = (fullIncome) / numberOfSectors;
            charityMoney = (fullIncome - (0.75 * onePartIncome)) / 8;
            Console.WriteLine("Total income - {0:F2} BGN",fullIncome);
            Console.WriteLine("Money for charity - {0:F2} BGN",charityMoney);
            Console.ReadKey();

        }
    }
}
