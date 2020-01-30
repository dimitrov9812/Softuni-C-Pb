using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var studentInfo = new Dictionary<string, List<double>>();
            var studentPrint = new Dictionary<string,double>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentInfo.ContainsKey(name))
                {
                    studentInfo.Add(name,new List<double>());
                }
                studentInfo[name].Add(grade);
            }
            foreach (var student in studentInfo)
            {
                studentPrint.Add(student.Key, student.Value.Average());
            }
            foreach (var student in studentPrint.OrderByDescending(x=>x.Value))
            {
                if(student.Value>=4.50)
                Console.WriteLine($"{student.Key} -> {student.Value:F2}");
            }
        }
    }
}
