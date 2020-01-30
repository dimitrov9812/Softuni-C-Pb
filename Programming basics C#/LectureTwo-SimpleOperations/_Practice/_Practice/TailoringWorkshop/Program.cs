using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {

            int tableNum = int.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());
            double tableLength = double.Parse(Console.ReadLine());
           
            double coversarea = tableNum * (tableLength + 2 * 0.30) * (tableWidth + 2 * 0.30);
            double smallcoverarea = tableNum * (tableLength / 2) * (tableLength / 2);  
            
            double priceInDollars = coversarea * 7 + smallcoverarea * 9;
            double priceInLeva = priceInDollars * 1.85;

            Console.WriteLine($"{priceInDollars:F2} USD");
            Console.WriteLine($"{priceInLeva:F2} BGN");
        }
    }
}
