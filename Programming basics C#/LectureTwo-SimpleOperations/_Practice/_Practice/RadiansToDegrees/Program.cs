using System;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //get radians
            double rad = double.Parse(Console.ReadLine());

            //calculate in degrees
            double degrees = rad * 180 / Math.PI;
            //round the number and print it
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
