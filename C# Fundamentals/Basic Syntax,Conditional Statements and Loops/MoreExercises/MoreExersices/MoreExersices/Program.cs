using System;

namespace MoreExersices
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int biggest = 0;
            int middle = 0;
            int smallest = 0;

            if (first >= second && first >= third)
            {
                biggest = first;
                if (second >= third)
                {
                    middle = second;
                    smallest = third;
                }
                else if (second <= third)
                {
                    middle = third;
                    smallest = second;
                }

            }
            else if (second >= first && second >= third)
            {
                biggest = second;
                if (first >= third)
                {
                    middle = first;
                    smallest = third;
                }
                else if (first <= third)
                {
                    middle = third;
                    smallest = first;
                }

            }
            else if (third >= first && third >= second)
            {
                biggest = third;
                if (first >= second)
                {
                    middle = first;
                    smallest = second;
                }
                else if (first <= second)
                {
                    middle = second;
                    smallest = first;
                }

            }
            
            Console.WriteLine(biggest);
            Console.WriteLine(middle);
            Console.WriteLine(smallest);
            

        }
    }
}
