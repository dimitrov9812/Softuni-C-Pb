using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoC
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double TimeSeconds = double.Parse(Console.ReadLine());

            double mustSwim = distanceMeters * TimeSeconds;
            double addTime = (Math.Floor(distanceMeters / 15)) * 12.5;
            double TotalTime = Math.Abs(mustSwim + addTime);

            if (recordSeconds <= TotalTime)
            {
                Console.WriteLine($"No, he failed! He was {TotalTime - recordSeconds:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {TotalTime:f2} seconds.");
            }
        }
    }
}
