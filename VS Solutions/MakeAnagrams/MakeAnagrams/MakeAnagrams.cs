using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/**
 * Given two strings (a, b)
 * Prints the number of characters you must delete to make the two strings anagrams of each other. 
 **/

class MakeAnagrams
{
    static void Main(String[] args)
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        int[] charCount = new int[26];
        int deleteCount = 0;

        for (int i = 0; i < a.Length; i++)
        {
            charCount[a[i] - 'a']++;
        }
        for (int i = 0; i < b.Length; i++)
        {
            charCount[b[i] - 'a']--;
        }
        for (int i = 0; i < charCount.Length; i++)
        {
            deleteCount += Math.Abs(charCount[i]);
        }

        Console.WriteLine(deleteCount);
    }
}