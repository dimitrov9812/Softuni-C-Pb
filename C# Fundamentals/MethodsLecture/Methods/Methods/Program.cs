using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CheckNumber(number);
        }

        static void CheckNumber(int number)
        {
            if(number > 0)
            {
                Console.WriteLine("The number {0} is positive.",number);
            }
            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative.",number);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.",number);
            }
        }
    }
}
