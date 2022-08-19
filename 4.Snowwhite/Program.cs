using System;
using System.Collections.Generic;
using System.Linq;
namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                var commands = Console.ReadLine().Split(" ");
                var actions = commands[0];
                var userName = commands[1];
                switch (actions)
                {
                    case "register":
                        var plateNumber = commands[2];
                        if (checkIfUserNameNotExist(users, userName))
                        {
                            users.Add(userName, plateNumber);
                            Console.WriteLine($"{userName} registered {plateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                        }
                        break;
                    case "unregister":
                        if (checkIfUserNameNotExist(users, userName))
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        else
                        {
                            Console.WriteLine($"{userName} unregistered successfully");
                            users.Remove(userName);
                        }
                        break;
                }
            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
        static bool checkIfUserNameNotExist(Dictionary<string, string> users, string name) => !users.ContainsKey(name);
    }
}

