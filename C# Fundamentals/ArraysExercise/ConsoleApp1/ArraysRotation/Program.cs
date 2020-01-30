using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRotation
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < numbers.Length-1; i++)
            {
                int currentNum = numbers[i];
                bool isTopInteger = true;
                for (int k = i+1; k < numbers.Length; k++)
                {
                    int otherNum = numbers[k];
                    if (currentNum<otherNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write(currentNum+" ");
                }
            }
            Console.WriteLine(numbers[numbers.Length-1]);
           
            
        }
    }
}
