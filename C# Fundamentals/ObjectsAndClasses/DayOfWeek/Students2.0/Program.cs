using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] splittedCommand = command.Split(' ');
                string fName = splittedCommand[0];
                string lName = splittedCommand[1];
                int age = int.Parse(splittedCommand[2]);
                string town = splittedCommand[3];
                Student student = students.FirstOrDefault(s => s.FirstName == fName && s.LastName == lName);
                if (student == null)
                {
                    students.Add(new Student()
                    {
                        FirstName = fName,
                        LastName = lName,
                        Age = age,
                        HomeTown = town
                    });
                }
                else
                {
                    student.FirstName = fName;
                    student.LastName = lName;
                    student.Age = age;
                    student.HomeTown = town;
                }
                command = Console.ReadLine();
            }
            string chooseTown = Console.ReadLine();
            foreach (var student in students)
            {
                if (chooseTown == student.HomeTown)
                {
                    Console.WriteLine("{0} {1} is {2} years old.", student.FirstName, student.LastName, student.Age);
                }
            }
        }
        static bool IsExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

