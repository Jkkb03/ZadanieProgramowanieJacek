// Write a C# Sharp program to remove the first and last elements from a given string.
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] words = { "Kawa", "Samochód", "Zegar" };

        foreach (string word in words)
        {
            Console.WriteLine($"Original string: {word}");
            string result = RemoveFirstAndLast(word);
            Console.WriteLine($"After removing first and last elements: {result}");
        }
    }

    static string RemoveFirstAndLast(string input)
    {
        if (input.Length <= 2)
        {
            return "";
        }
        return input.Substring(1, input.Length - 2);
    }
}
