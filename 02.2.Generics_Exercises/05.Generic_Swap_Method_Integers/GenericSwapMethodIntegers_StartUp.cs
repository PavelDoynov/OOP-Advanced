/*
 * 05. Generic Swap Method Integers
 * 
 * Use the description of the previous problem but now, test your list of generic boxes with Integers.
 * 
 * Example
 * Input           Output
 * 3               System.Int32: 42      
 * 7               System.Int32: 123
 * 123             System.Int32: 7
 * 42
 * 0 2
 * 
 * https://github.com/PavelDoynov
 */


using System;
using System.Collections.Generic;
using System.Linq;

class GenericSwapMethodIntegers_StartUp
{
    static void Main(string[] args)
    {
        List<Box<int>> box = new List<Box<int>>();

        int numberOfLines = int.Parse(Console.ReadLine());

        while (numberOfLines != 0)
        {
            box.Add(new Box<int>(int.Parse(Console.ReadLine())));

            numberOfLines--;
        }

        int[] swapIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Swap(box, swapIndexes[0], swapIndexes[1]);

        foreach (var item in box)
        {
            Console.WriteLine(item);
        }
    }

    private static void Swap<T>(List<T> box, int v1, int v2)
    {
        T value = box[v1];
        box[v1] = box[v2];
        box[v2] = value;
    }
}

