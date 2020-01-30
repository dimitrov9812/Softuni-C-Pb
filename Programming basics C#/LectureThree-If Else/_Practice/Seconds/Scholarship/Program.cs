using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double montlyInCome = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minWage = double.Parse(Console.ReadLine());
            var social = 0d;
            var exGrade = 0d;
            if (averageGrade >= 4.50 && minWage > montlyInCome)
            {
                social = minWage * 0.35;
            }
            if (averageGrade >= 5.50)
            {
                exGrade = averageGrade * 25;
            }
            if (social != 0 || exGrade != 0)
            {
                var result = Math.Max(social, exGrade);
                Console.WriteLine(result == social ?
                    "You get a Social scholarship {0} BGN" : "You get a scholarship for excellent results {1} BGN",
                     (Math.Floor(social)), (Math.Floor(exGrade)));
            }
            else
                Console.WriteLine($"You cannot get a scholarship!");
        }
    }
}
