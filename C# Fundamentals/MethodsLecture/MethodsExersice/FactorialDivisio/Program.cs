using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDivisio
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = int.Parse(Console.ReadLine());
            double second = int.Parse(Console.ReadLine());
            double firstFac = CalculateFactorial(first);
            double secondFac = CalculateFactorial(second);
            double result = FacDivision(firstFac,secondFac);
            Console.WriteLine("{0:f2}",result);
        }
        static double CalculateFactorial(double a)
        {
            
            double factorial = 1;
            if (a == 0)
            {
                return factorial = 1;
            }
            for (long i = 1; i<=a ; i++)
            {
                factorial *= i;//1*1 -> 2*1->3*2->4*6->5*24->24
            }
            return Math.Abs(factorial);
        }
        static double FacDivision(double a, double b)
        {
            return a / b;
        }

    }
}
