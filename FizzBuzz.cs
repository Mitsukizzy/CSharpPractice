using System;

public class FizzBuzz
{
    public static void Main()
    {
        for (int i = 1; i < 100; i++)
        {
            // If divisible by 3, Fizz
            // If divisible by 5, Buzz
            // If multiples of 3 and 5, FizzBuzz


            if (i % 5 == 0 && i % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }

#if DEBUG
        Console.WriteLine("\nPress enter to close...");
        Console.ReadLine();
#endif
    }
}