using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateRectangularArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double result = Area(a, b);
            Console.WriteLine(result);
        }
        static int Area(int a , int b)
        {
            int result = a * b;
            return result;
        }
    }
}
