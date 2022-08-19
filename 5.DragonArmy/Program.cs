using System;
using System.Collections.Generic;
namespace CountCharsinaString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray(); 
            Dictionary<char, int> letters = new Dictionary<char, int>();
            foreach (var letter in word)
            {
                if (letter != ' ')
                {
                    if (!letters.ContainsKey(letter))
                    {
                        letters[letter] = 0;
                    }
                    letters[letter]++;
                }
            }
            foreach (var kvpLetters in letters)
            {
                Console.WriteLine($"{kvpLetters.Key} -> {kvpLetters.Value}"); // t -> 2
            }
        }
    }
}
