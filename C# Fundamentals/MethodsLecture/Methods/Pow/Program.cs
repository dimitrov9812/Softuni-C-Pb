using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pow
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            double result = Pow(number, times);
            Console.WriteLine(result); 
        }
        static double Pow (double a, int b)
        {
            double result = 1 ;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }
    }
}
