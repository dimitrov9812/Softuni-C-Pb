using System;

namespace Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the times for the 3 competitors
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            //make sum of the times
            int sum = first + second + third;

            //calculate the result in minutes:seconds
            int minutes = sum / 60;
            int seconds = sum % 60;
            if (seconds <= 9)
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
            

            //Print
        }
    }
}
