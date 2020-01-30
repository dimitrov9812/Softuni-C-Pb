using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var racerNames = Console.ReadLine().Split(new[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
            var racerData = new Dictionary<string,int>();
            var bestRacers = new List<string>();
            string pattern = @"\w";
            string inputData;

            while ((inputData = Console.ReadLine()) != "end of race")
            {
                string temporaryDigits = "";
                string temporaryName = "";
                MatchCollection matches = Regex.Matches(inputData, pattern);
                foreach (Match match in matches)
                {
                    char current = char.Parse(match.Value);
                    if (Char.IsDigit(current))
                    {
                        temporaryDigits += current;
                    }
                    else
                    {
                        temporaryName += current;
                    }
                }
                string name = temporaryName.Trim();
                string distanceNumbersToAdd = temporaryDigits.Trim();
                if (racerNames.Contains(name))
                {
                    int distance = 0;
                    if (!racerData.ContainsKey(name))
                    {
                        foreach (char digit in distanceNumbersToAdd)
                        {
                            int numberToAdd = int.Parse(digit.ToString());
                            distance += numberToAdd;
                        }
                        racerData.Add(name, distance);
                    }
                    else
                    {
                        racerData[name] += distance;
                    }
                }
            }

            foreach (var kvp in racerData.OrderByDescending(key => key.Value))
            {
                string name = kvp.Key;
                bestRacers.Add(name);
                if (bestRacers.Count == 4)
                {
                    break;
                }
            }
            Console.WriteLine($"1st place: {bestRacers[0]}");
            Console.WriteLine($"2nd place: {bestRacers[1]}");
            Console.WriteLine($"3rd place: {bestRacers[2]}");
        }
    }
}
