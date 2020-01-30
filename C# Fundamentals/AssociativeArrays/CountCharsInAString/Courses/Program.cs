using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] splittedCommand = command.Split(':');
                string courseName = splittedCommand[0];
                string studentName = splittedCommand[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(studentName);
            }
            foreach (var course in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine("{0}: {1}", course.Key, course.Value.Count);
                foreach (var name in course.Value.OrderBy(n => n))
                {
                    Console.WriteLine("-- {0}", name);
                }
            }
        }
    }
}
