using System;

class Palindrome
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome("Potato"));
        Console.WriteLine(IsPalindrome("Racecar"));
        Console.WriteLine(IsPalindrome("8675309"));
        Console.WriteLine(IsPalindrome("3717173"));

#if DEBUG
        Console.WriteLine("\nPress enter to close...");
        Console.ReadLine();
#endif
    }

    /**
     *  An alternate way would be to copy the string to a new array and call Array.Reverse
     *  I prefer the method below as it only uses one array and is fairly straightforward
     **/
    public static bool IsPalindrome(string word)
    {
        // Ensure the characters are the same case
        word = word.ToLower(); 

        int i = 0;
        int j = word.Length - 1;

        while(i < j)
        {
            if(word[i] != word[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }

    public static bool IsPalindrome(int num)
    {
        return IsPalindrome(num.ToString());
    }
}