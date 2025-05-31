// Write a C# Sharp program that prints the multiplication table of a number as input.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Multiplication table of {number}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}
