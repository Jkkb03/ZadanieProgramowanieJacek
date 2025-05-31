// Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input the first number: ");
        int liczba1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the second number: ");
        int liczba2 = Convert.ToInt32(Console.ReadLine());

        int sum = liczba1 + liczba2;
        int difference = liczba1 - liczba2;
        int product = liczba1 * liczba2;
        int quotient = liczba1 / liczba2;
        int remainder = liczba1 % liczba2;

        Console.WriteLine($"{liczba1} + {liczba2} = {sum}");
        Console.WriteLine($"{liczba1} - {liczba2} = {difference}");
        Console.WriteLine($"{liczba1} x {liczba2} = {product}");
        Console.WriteLine($"{liczba1} / {liczba2} = {quotient}");
        Console.WriteLine($"{liczba1} mod {liczba2} = {remainder}");
    }
}
