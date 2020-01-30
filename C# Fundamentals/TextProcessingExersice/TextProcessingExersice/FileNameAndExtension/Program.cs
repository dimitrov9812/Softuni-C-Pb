using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNameAndExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string link = Console.ReadLine();
            string extension = "";
            var file = new List<char>();
            var linkWithoutExtension = new List<char>();
            for (int i = 0; i < link.Length; i++)
            {
                char currentChar = link[i];
                int index = link.IndexOf(currentChar);
                if(currentChar != '.')
                {
                   link.Remove(index);
                }
                else if(currentChar == '.')
                {
                    link.Remove(index);
                    for (int j = i + 1; j < link.Length; j++)
                    {
                        extension += link[j];
                    }
                    break;
                }
            }
            foreach (var character in link)
            {
                linkWithoutExtension.Add(character);
            }
            linkWithoutExtension.Reverse();
            
            for (int i = 0; i < linkWithoutExtension.Count; i++)
            {
                char current = linkWithoutExtension[i];
                if(current == '.')
                {
                    i++;
                    for (int j = i; j < linkWithoutExtension.Count; j++)
                    {
                        if (linkWithoutExtension[j] != (char)92)
                        {
                            file.Add(linkWithoutExtension[j]);
                        }
                        else
                        {

                            break;
                        }
                    }
                    break;
                }
            }
            file.Reverse();
            Console.WriteLine("File name: " + string.Join("", file));
            Console.WriteLine("File extension: "+ extension);
        }
    }
}
