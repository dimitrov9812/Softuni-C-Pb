using System;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //int peopleNum = int.Parse(Console.ReadLine());
            //double finalAverage = 0.00;
            //double allSum = 0.00;
            //double gradecount = 0;
            //while (true)
            //{
            //    double sum = 0.00;
            //    double average = 0.00;               
            //    double grade=0.00;

            //    string presentationName;
            //    presentationName = Console.ReadLine();
            //    if (presentationName == "Finish")
            //    {
            //        finalAverage = allSum / gradecount;

            //        Console.WriteLine("Student's final assessment is {0:F2}",finalAverage);
            //        break;

            //    }
            //    else
            //    {
            //        for (int i = 0; i < peopleNum; i++)
            //        {
            //            grade = double.Parse(Console.ReadLine());
            //            sum += grade;
            //            allSum += grade;
            //            gradecount++;
            //        }
            //        average = sum / peopleNum;
            //        Console.WriteLine("{0} - {1:F2}", presentationName, average);s

            //    }


            //}
            int numberOfPeople = int.Parse(Console.ReadLine());
            double allScore = 0;
            double counter = 0;

            while (true)
            {
                string nameOfPresentation = Console.ReadLine();
                double sumOfGrades = 0;

                if (nameOfPresentation == "Finish")
                {
                    double scoreSum = allScore / counter;
                    Console.WriteLine($"Student's final assessment is {scoreSum:f2}.");
                    break;
                }
                for (int i = 0; i < numberOfPeople; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades += grade;
                    allScore += grade;
                    counter++;
                }
                double sumAfter = sumOfGrades / numberOfPeople;
                Console.WriteLine($"{nameOfPresentation} - {sumAfter:f2}.");

            }
        }
    }
}
