using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();   
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int numberOfTickets = rows * columns;
            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5.00;
            double sum = 0;
            switch (type)
            {
                case "Premiere":
                    sum = premiere * numberOfTickets;
                    Console.WriteLine("{0:F2} leva",sum);
                    break;
                case "Normal":
                    sum = normal * numberOfTickets;
                    Console.WriteLine("{0:F2} leva", sum);
                    break;
                case "Discount":
                    sum = discount * numberOfTickets;
                    Console.WriteLine("{0:F2} leva", sum);
                    break;
            }
            
        }
    }
}
