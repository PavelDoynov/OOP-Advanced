/*
 * 04. Froggy
 * 
 * Let's play a game. You have a tiny little Frog, and a Lake that has a path of stones in it. Every stone has a number.
 * Our frog must cross the lake along that path and then return. But there are some rules when jumping on the stones. 
 * First, the frog must jump on all even positions of the stones in ascending order and then on all odd positions 
 * but in reversed order. The order of the stones and their numbers will be given on the first line of input. 
 * Then you must print the order of stones in which our frog jumped from one to another.
 * 
 * Try to achieve this functionality by creating a class Lake (it will hold all stone numbers in order) that 
 * implements IEnumerable<int> interface and overrides its GetEnumerator() methods.
 * 
 * Example
 * Input:                            Output:
 * 1, 2, 3, 4, 5, 6, 7, 8            1, 3, 5, 7, 8, 6, 4, 2
 * 
 * Input:                            Output:
 * 1, 2, 3, 4, 5                     1, 3, 5, 4, 2
 * 
 * Input:                            Output:
 * 13, 23, 1, -8, 4, 9               13, 1, 4, 9, -8, 23
 * 
 * https://github.com/PavelDoynov
 */


using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] stones = Console.ReadLine()
                              .Split(',', StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();

        Lake<int> lake = new Lake<int>(stones);

        int index = 0;
        int[] arrResult = new int[stones.Length];

        foreach (var stone in lake)
        {
            arrResult[index] = stone;
            index++;
        }

        Console.WriteLine(string.Join(", ", arrResult));
    }
}