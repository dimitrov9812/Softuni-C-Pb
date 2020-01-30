using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int a = int.Parse(Console.ReadLine());
            char input =char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            switch (input)
            {
                case '+':
                    Add(a, b);
                    break;
                case '-':
                    Subtract(a, b);
                    break;
                case '*':
                    Multiply(a, b);
                    break;
                case '/':
                    Divide(a, b);
                    break;

                default:
                    break;
            }
        }
        static void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
