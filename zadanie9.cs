// Write a C# program to reverse the words of a sentence.
using System;

class Program
{
    static void Main(string[] args)
    {
        string sentence = "Wczoraj by³em na imprezie i zgubi³em portfel.";

        Console.WriteLine("Original Sentence:");
        Console.WriteLine(sentence);

        string reversed = ReverseSentence(sentence);

        Console.WriteLine("Reversed Sentence:");
        Console.WriteLine(reversed);
    }

    static string ReverseSentence(string input)
    {
        string[] words = input.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
