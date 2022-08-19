using System;
using System.Collections.Generic;
using System.Linq;
namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courseInfo = new Dictionary<string, List<string>>();
            string cmd = Console.ReadLine();
            while (cmd != "end")
            {
                string[] tokens = cmd.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                var courseName = tokens[0];
                var studentName = tokens[1];
                if (!courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName] = new List<string>();
                }
                courseInfo[courseName].Add(studentName);
                cmd = Console.ReadLine();
            }
            PrintCourseInfo(courseInfo);
        }
        private static void PrintCourseInfo(Dictionary<string, List<string>> courseInfo)
        {
            foreach (var kvp in courseInfo)
            {
                string courseName = kvp.Key;
                Console.WriteLine($"{courseName}: {kvp.Value.Count}");
                foreach (string student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
