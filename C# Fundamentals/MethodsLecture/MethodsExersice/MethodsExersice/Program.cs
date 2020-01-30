using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallerOfThree(first, second, third));
        }
        static int SmallerOfThree(int a, int b, int c)
        {
            int smallest = int.MaxValue;
            if (a < smallest)
            {
                smallest = a;
                if (b < smallest)
                {
                    smallest = b;
                }
                else if (c < smallest)
                {
                    smallest = c;
                }
                else
                {
                    smallest = a;
                }
            }
            if (b < smallest)
            {
                smallest = b;
                if (a < smallest)
                {
                    smallest = a;
                }
                else if (c < smallest)
                {
                    smallest = c;
                }
                else
                {
                    smallest = b;
                }
            }
            if (c < smallest)
            {
                smallest = c;
                if (b < smallest)
                {
                    smallest = b;
                }
                else if (a < smallest)
                {
                    smallest = a;
                }
                else
                {
                    smallest = c;
                }
            }
            return smallest;
        }


    }
}
