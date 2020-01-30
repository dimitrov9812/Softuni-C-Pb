using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Dictionary<string, List<string>>();
            string command;
            while((command=Console.ReadLine())!="End")
            {
                string splitter = "->";
                string[] splittedCommand = command.Trim().Split(splitter.ToArray());
                string companyName = splittedCommand[0];
                string id = splittedCommand[2];
                if (!company.ContainsKey(companyName))
                {
                    company.Add(companyName, new List<string>());
                    if (!company[companyName].Contains(id))
                    {
                        company[companyName].Add(id);
                    }
                }
                if (!company[companyName].Contains(id))
                {
                    company[companyName].Add(id);
                }
            }
            foreach (var companyName in company.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{companyName.Key}");
                foreach (var worker in companyName.Value)
                {
                    Console.WriteLine($"-- {worker}");
                }
            }
        }
    }
}
