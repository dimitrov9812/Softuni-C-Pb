using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(Add(first, second), third));
        }
        static int Add(int first, int second)
        {
            return first + second;
        }
        static int Subtract(int first, int third)
        {
            return first - third;
        }
    }
}
