using System;

namespace BestSoccerPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            
            string bestplayerName="";
            int bestGoals = 0;
            while(true)
            {
                if (name == "END")
                {
                    break;
                }
                int goalsScored = int.Parse(Console.ReadLine());
                if (goalsScored> bestGoals)
                {
                    bestplayerName = name;
                    bestGoals = goalsScored;
                }
                if(bestGoals >= 10)
                {
                    break;
                }
                name = Console.ReadLine();
                
                
            }
            Console.WriteLine("{0} is the best player!",bestplayerName);
            if (bestGoals >= 3)
            {               
                Console.WriteLine("He has scored {0} goals and made a hat-trick !!!",bestGoals);
            }
            else
            { 
                Console.WriteLine("He has scored {1} goals.",bestGoals);
            }
           

        }
    }
}
