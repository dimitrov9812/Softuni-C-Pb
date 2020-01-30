using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            StringPrinter(value, times);
        }
        static void StringPrinter(string value,int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(value);
            }
        }
    }
}
