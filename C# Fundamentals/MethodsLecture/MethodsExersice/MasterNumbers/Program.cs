using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Print(number);
        }
        static bool MasterNumber(int a)
        {
            int digitSum = 0;
            bool oddDigit = false;
            while (a != 0)
            {
                int currentNum = a % 10;
                if (a % 2 == 1)
                {
                    oddDigit = true;
                }
                digitSum += currentNum;
                a /= 10;
            }
            if (digitSum % 8 == 0 && oddDigit == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Print(int a)
        {
            
            for (int i = 0; i < a; i++)
            {
                bool isMasterNumber = MasterNumber(i);
                if(isMasterNumber == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
