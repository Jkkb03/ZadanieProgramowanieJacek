// Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.
using System;

class Program
{
    static void Main(string[] args)
    {
        int digit = 7;

        Console.WriteLine($"Drawing a rectangle using digit: {digit}");
        DrawRectangle(digit, 3, 5);
    }

    static void DrawRectangle(int digit, int width, int height)
    {
        string row = CreateRow(digit, width);
        for (int i = 0; i < height; i++)
        {
            Console.WriteLine(row);
        }
    }

    static string CreateRow(int digit, int width)
    {
        string row = "";
        for (int i = 0; i < width; i++)
        {
            row += digit;
        }
        return row;
    }
}
