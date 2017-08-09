using System;
using System.Collections.Generic;
using System.IO;

class Fibonacci
{
    public static int RecursiveFib(int n)
    {
        if (n < 2)
        {
            return n;
        }
        return RecursiveFib(n - 1) + RecursiveFib(n - 2);
    }

    public static int IterativeFib(int n)
    {
        int x = 1;
        int y = 1;
        int result = y;

        if (n < 2)
        {
            return n;
        }

        for (int i = 2; i < n; i++)
        {
            result = x + y;
            x = y;
            y = result;
        }
        return result;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(RecursiveFib(n));
        Console.WriteLine(IterativeFib(n));
    }
}
