using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            int small = 0;
            int big = 0;
            List<int> result = new List<int>();
            if(first.Count < second.Count)
            {
                small = first.Count;
                big = second.Count;
            }
            else
            {
                small= second.Count;
                big = first.Count;
            }
            for (int i = 0; i <small ; i++)
            {
                result.Add(first[i]);
                result.Add(second[i]);
            }
            for (int i = small; i <big ; i++)
            {
                if (first.Count > second.Count)
                {
                    result.Add(first[i]);
                }
                else
                {
                    result.Add(second[i]);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }

    }
}
