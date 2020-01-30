using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the input
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            //
            int freeBelts = 0;
            for (int i = 1; i <= studentsCount; i++)
            {
                if(i%6 == 0)
                {
                    freeBelts += 1;
                }
            }
            double finalsaberPrice = saberPrice * (Math.Ceiling(studentsCount + studentsCount * 0.1));
            double finalPrice = (finalsaberPrice + (robesPrice * studentsCount) + (beltsPrice * (studentsCount-freeBelts)));
            if(finalPrice <= money)
            {
                Console.WriteLine("The money is enough - it would cost {0:f2}lv.",finalPrice);
            }
            else
            {
                Console.WriteLine("Ivan Cho will need {0:f2}lv more.",finalPrice-money);
            }


        }
    }
}
