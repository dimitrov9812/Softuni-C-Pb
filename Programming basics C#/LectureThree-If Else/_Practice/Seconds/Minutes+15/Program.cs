using System;

namespace Minutes_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int timeinminutes = hour * 60 + minutes;
            int timeplus15 = timeinminutes + 15;
            int finalhour = timeplus15 / 60;
            int finalminutes = timeplus15 % 60;
            if (finalhour >= 24)
            {
                finalhour -= 24;
                
               
            }
            if (finalminutes <= 9)
            {
                Console.WriteLine("{0}:0{1}", finalhour, finalminutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", finalhour, finalminutes);
            }

        }
    }
}
