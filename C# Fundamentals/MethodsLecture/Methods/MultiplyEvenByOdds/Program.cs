using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetEvenSum(Math.Abs(n))*GetOddSum(Math.Abs(n)));
        }
        static int GetEvenSum(int n)
        {
            int evenSum = 0;
            int currentNum = 0;
            while (n >= 0)
            {
                currentNum = n % 10;
                if(currentNum%2 == 0)
                {
                    evenSum += currentNum;
               }
                n/=10;
                if (n == 0)
                {
                    break;

                }
            }
            return evenSum;
        }
        static int GetOddSum(int n)
        {
            int oddSum = 0;
            int currentNum = 0;
            while (n >= 0)
            {
                currentNum = n % 10;
                if (currentNum % 2 == 1)
                {
                    oddSum += currentNum;
                }
                n /= 10;
                if (n == 0)
                {
                    break;

                }
            }
            return oddSum;
        }
    }
}
