using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> detonator = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = detonator[0];
            int power = detonator[1];
            Detonate(numbers, bomb, power);
            Console.WriteLine(numbers.Sum());
            
        }
        static void Detonate(List<int> list,int bomb, int power)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bomb)
                {
                    int bombpossition = i;
                    int leftstartIndex;
                    if (bombpossition - power < 0)
                    {
                        if (bombpossition + power > list.Count-1)
                        {
                            int fromBombToEndRight = list.Count - bombpossition;
                            leftstartIndex = 0;
                            list.RemoveRange(leftstartIndex, power*2+1);
                        }
                        else
                        {
                            leftstartIndex = 0;
                            list.RemoveRange(leftstartIndex, power*2+1);
                        }
                       
                    }
                    else
                    {
                        if(bombpossition+power > list.Count-1)
                        {
                            int rightPower = (list.Count-1)-bombpossition;    //7+4 = 13 --                    
                            leftstartIndex = bombpossition - power;
                            list.RemoveRange(leftstartIndex, power+ rightPower+1);                          
                           
                        }
                        else
                        {
                            leftstartIndex = bombpossition - power;
                            list.RemoveRange(leftstartIndex, power*2+1);
                        }
                       
                    }                            
                    i--;
                }
            }
            
        }
    }
}
