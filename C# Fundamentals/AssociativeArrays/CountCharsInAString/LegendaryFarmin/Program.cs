using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var backPack = new Dictionary<string, int>();
            var junk = new Dictionary<string, int>();
            var items = new List<string>()
            {
                "motes",
                "fragments",
                "shards"
            };
            string unlockedLegendary = "";
            bool breakLoop = true;
            while (breakLoop)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                string currentMaterial = "";
                int currentValue = 0;
                for (int i = 0; i < input.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        currentValue = int.Parse(input[i]);
                        currentMaterial = input[i + 1].ToLower();
                        if (IsJunk(currentMaterial))
                        {
                            if (!junk.ContainsKey(currentMaterial))
                            {
                                junk.Add(currentMaterial, currentValue);
                            }
                            else
                            {
                                junk[currentMaterial] += currentValue;
                            }

                        }
                        else
                        {
                            if (!backPack.ContainsKey(currentMaterial))
                            {
                                backPack.Add(currentMaterial, currentValue);
                            }
                            else
                            {
                                backPack[currentMaterial] += currentValue;
                            }
                            if (backPack[currentMaterial] >= 250)
                            {
                                backPack[currentMaterial] -= 250;
                                switch (currentMaterial)
                                {
                                    case "shards":
                                        unlockedLegendary = "Shadowmourne";
                                        break;
                                    case "fragments":
                                        unlockedLegendary = "Valanyr";
                                        break;
                                    case "motes":
                                        unlockedLegendary = "Dragonwrath";
                                        break;
                                    default:
                                        break;

                                }
                                breakLoop = false;
                            }
                        }
                    }
                }
            }
            backPack = backPack
                .OrderBy(x => x.Key)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            junk = junk
               .OrderBy(x => x.Key)
               .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine($"{unlockedLegendary} obtained!");
            foreach (var item in items)
            {
                if (!backPack.ContainsKey(item))
                {
                    backPack.Add(item, 0);
                }
            }
            foreach (var kvp in backPack)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            
            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
        static bool IsJunk(string material)
        {
            if (material == "shards" || material == "fragments" || material == "motes")
            {
                return false;
            }
            return true;
        }
       
    }
}