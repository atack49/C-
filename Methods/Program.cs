﻿namespace Methods;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        PrintSum();
    }

    private static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    public static void PrintSum()
    {
        int sum = AddNumbers(5, 10);
        Console.WriteLine($"The sum is:{sum}");

    }
}