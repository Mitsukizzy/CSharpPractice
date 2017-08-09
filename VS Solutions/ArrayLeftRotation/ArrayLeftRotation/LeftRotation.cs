using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/**
 * A left rotation operation on an array of size n shifts each of the array's elements 1 unit to the left. 
 * For example, if 2 left rotations are performed on array [1,2,3,4,5], then the array would become [3,4,5,1,2].
 * Given an array of n integers and a number, d, perform d left rotations on the array. Then print the updated array as a single line of space-separated integers.
 * 
 * Input Format
 * The first line contains two space-separated integers denoting the respective values of n (the number of integers) and d (the number of left rotations you must perform). 
 * The second line contains n space-separated integers describing the respective elements of the array's initial state. 
 * */

class LeftRotation
{

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);

        for (int i = 0; i < n; i++)
        {
            if (k + i < n)
            {
                Console.Write(a[k + i] + " ");
            }
            else
            {
                Console.Write(a[k + i - n] + " ");
            }
        }
    }
}
