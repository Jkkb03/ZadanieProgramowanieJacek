// Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
using System;

class Program
{
    static void Main(string[] args)
    {
        int number1 = -8;
        int number2 = 15;

        bool result = CheckRange(number1, number2);

        Console.WriteLine($"Is either {number1} or {number2} in the range -10 to 10?");
        Console.WriteLine(result);
    }

    static bool CheckRange(int num1, int num2)
    {
        return (num1 >= -10 && num1 <= 10) || (num2 >= -10 && num2 <= 10);
    }
}
