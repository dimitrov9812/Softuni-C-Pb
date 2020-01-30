using System;

namespace ToExamOnTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());
            if (arrivalHour > examHour)
            {
                Console.WriteLine("Late");
                if (arrivalHour - examHour < 1)
                {
                    Console.WriteLine("{0} minutes after the start", arrivalMinutes - examMinutes);
                }
                else if (arrivalHour - examMinutes >= 1)
                {
                    Console.WriteLine("{0}:{1} hours after the start", arrivalHour - examHour, arrivalMinutes - examMinutes);
                }
            }
            else if (arrivalHour == examHour && arrivalMinutes == examMinutes || examMinutes - arrivalMinutes <= 30)
            {

            }

        }
    }
}
