using System;
using System.Collections.Generic;
namespace _8.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();
            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                string[] tokens = cmd.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                var companyName = tokens[0];
                var employeeId = tokens[1];
                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }
                if (companies[companyName].Contains(employeeId))
                {
                    cmd = Console.ReadLine();
                    continue;
                }
                else
                {
                    companies[companyName].Add(employeeId);
                }
                cmd = Console.ReadLine();
            }
            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");
                foreach (string name in company.Value)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
