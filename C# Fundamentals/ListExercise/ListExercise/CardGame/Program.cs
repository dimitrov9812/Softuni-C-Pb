using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //read the decks
            List<int> firstDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (firstDeck.Count != 0 || secondDeck.Count != 0)
            {
                int counter = 0;
                if (firstDeck.Count == 0 || secondDeck.Count == 0)
                {
                    break;
                }
                else
                {
                    int firstDeckCard = firstDeck[counter];
                    int secondDeckCard = secondDeck[counter];
                    //compare cards

                    if (firstDeckCard > secondDeckCard)
                    {
                        //put them back or delete them
                        secondDeck.Remove(secondDeckCard);
                        firstDeck.Remove(firstDeckCard);
                        firstDeck.Add(firstDeckCard);
                        firstDeck.Add(secondDeckCard);
                    }
                    else if (secondDeckCard > firstDeckCard)
                    {
                        //put them back or delete them
                        firstDeck.Remove(firstDeckCard);
                        secondDeck.Remove(secondDeckCard);
                        secondDeck.Add(secondDeckCard);
                        secondDeck.Add(firstDeckCard);
                    }
                    else if (secondDeckCard == firstDeckCard)
                    {
                        //delete them
                        firstDeck.Remove(firstDeckCard);
                        secondDeck.Remove(secondDeckCard);
                    }

                }
            }
            if (firstDeck.Count == 0)
            {
                Console.WriteLine("Second player wins! Sum: {0}", secondDeck.Sum());

            }
            else
            {
                Console.WriteLine("First player wins! Sum: {0}", firstDeck.Sum());
            }


            
            
        }
    }
}
