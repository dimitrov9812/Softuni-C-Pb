using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(new char[] { ' ', ',' })
                .ToList();
            string input;
            while ((input = Console.ReadLine()) !="course start")
            {
                string[] splittedInput = input.Split(':');
                string command = splittedInput[0];
                string lesson = splittedInput[1];
                if (command == "Add")
                {
                    if (!schedule.Contains(lesson))
                    {
                        schedule.Add(lesson);
                    }
                }
                else if(command == "Insert")
                {
                    int index = int.Parse(splittedInput[2]);
                    if (!schedule.Contains(lesson))
                    {
                        schedule.Insert(index,lesson);
                    }
                }
                else if (command == "Remove")
                {
                    string exercise = "{0}-Exercise";
                    string exerciseName = string.Format(exercise, lesson);
                    if (schedule.Contains(lesson))
                    {
                        
                        schedule.Remove(lesson);
                    }
                    if (schedule.Contains(exerciseName))
                    {
                        schedule.Remove(exerciseName);
                    }
                }
                else if (command == "Swap")
                {
                    string secondLesson = splittedInput[2];
                    string exercise = "{0}-Exercise";
                    if (schedule.Contains(lesson) && schedule.Contains(secondLesson))
                    {
                        int firstLessonIndex = schedule.IndexOf(lesson);
                        int secondLessonIndex = schedule.IndexOf(secondLesson);

                        string firstLessonExercise = string.Format(exercise, lesson);
                        string secondLessonExercise = string.Format(exercise, secondLesson);
                        

                        if (schedule.Contains(firstLessonExercise))
                        {
                            schedule.Remove(firstLessonExercise);
                            int indexOfLesson = schedule.IndexOf(lesson);
                            schedule.Insert(indexOfLesson + 1, firstLessonExercise);

                        }
                        if (schedule.Contains(secondLessonExercise))
                        {
                            schedule.Remove(secondLessonExercise);
                            int indexOfLesson = schedule.IndexOf(secondLesson);
                            schedule.Insert(indexOfLesson + 1, secondLessonExercise);
                        }

                        
                    }
                }
                else if (command == "Exercise")
                {
                    string exercise = $"{lesson}-Exercise";
                    if (schedule.Contains(exercise))
                    {
                        if (schedule.Contains(lesson))
                        {
                            int index = schedule.IndexOf(lesson);
                            schedule.Insert(index + 1, exercise);
                        }
                        else
                        {
                            schedule.Add(lesson);
                            schedule.Add(exercise);
                        }
                    }
                    
                }
            }
            Console.WriteLine(string.Join(" ",schedule));
        }
    }
}
