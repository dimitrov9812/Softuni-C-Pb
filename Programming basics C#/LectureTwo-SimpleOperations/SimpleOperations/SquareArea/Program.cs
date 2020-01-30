using System;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //get square size of the console
            double squareSide = double.Parse(Console.ReadLine());
            //calculate the area
            double squareArea = Math.Pow(squareSide,2);
            //print to console
            Console.WriteLine("Square Area is: " +  squareArea);
        }
    }
}
