using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            double interest = 0;
            double count = 0;
            while (k<n)
            {
                interest = double.Parse(Console.ReadLine());
                if (interest < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    k = n;
                }
                else
                {
                    Console.WriteLine("Increase: {0:f2}", interest);
                    count += interest;
                    k++;
                }
                
            }
            Console.WriteLine("Total: {0:f2}",count);

        }
    }
}
