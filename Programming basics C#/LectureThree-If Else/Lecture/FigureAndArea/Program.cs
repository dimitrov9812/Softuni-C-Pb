using System;

namespace FigureAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            if(figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(side*side);
            }
            if(figureType == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine(sideA*sideB);
            }
            if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI*radius*radius);
            }
            if (figureType == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine((sideA*h)/2);
            }
        }
    }
}
