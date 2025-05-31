// Write a C# Sharp program that takes three numbers (2,3,4) and outputs (x+y).z and x.y + y.z
using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 2;
        int y = 3;
        int z = 4;

        int wynik1 = ObliczPierwszyWynik(x, y, z);
        int wynik2 = ObliczDrugiWynik(x, y, z);

        WyswietlWyniki(x, y, z, wynik1, wynik2);
    }

    static int ObliczPierwszyWynik(int x, int y, int z)
    {
        return (x + y) * z;
    }

    static int ObliczDrugiWynik(int x, int y, int z)
    {
        return (x * y) + (y * z);
    }

    static void WyswietlWyniki(int x, int y, int z, int wynik1, int wynik2)
    {
        Console.WriteLine($"Podane liczby: x={x}, y={y}, z={z}");
        Console.WriteLine($"(x + y) * z = {wynik1}");
        Console.WriteLine($"(x * y) + (y * z) = {wynik2}");
    }
}
