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
                Student student = new Student
                {
                    FirstName = fName,
                    LastName = lName,
                    Age = age,
                    HomeTown = town
                };
                students.Add(student);
                command = Console.ReadLine();
            }
            string chooseTown = Console.ReadLine();
            foreach (var student in students)
            {
                if (chooseTown == student.HomeTown)
                {
                    Console.WriteLine("{0} {1} is {2} years old.",student.FirstName,student.LastName,student.Age);
                }
            }
        }
    }
}
