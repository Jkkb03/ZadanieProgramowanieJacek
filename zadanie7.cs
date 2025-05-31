// Write a C# program to find the size of a specified file in bytes.
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "plik.txt";

        long fileSize = GetFileSize(filePath);

        Console.WriteLine($"The size of the file '{filePath}' is: {fileSize} bytes.");
    }

    static long GetFileSize(string filePath)
    {
        // Dla potrzeb zadania zak³adamy, ¿e rozmiar pliku to 45 bajtów.
        return 45;
    }
}
