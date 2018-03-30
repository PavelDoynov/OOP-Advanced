/*
 * 04. Generic Swap Method Strings
 * 
 * Create a generic method that receives a list containing any type of data and swaps the
 * elements at two given indexes.
 * As in the previous problems read n number of boxes of type String and add them to the list. 
 * On the next line, however you will receive a swap command consisting of two indexes.
 * Use the method you've created to swap the elements that 
 * correspond to the given indexes and print each element in the list.
 * 
 * Example
 * Input                       Output
 * 3                           System.String: Swap me with Pesho
 * Pesho                       System.String: Gosho
 * Gosho                       System.String: Pesho
 * Swap me with Pesho
 * 0 2
 * 
 * https://github.com/PavelDoynov
 */ 


using System;
using System.Collections.Generic;
using System.Linq;

class GenericSwapMethodString_StartUp
{
    static void Main(string[] args)
    {
        List<Box<string>> box = new List<Box<string>>();

        int numberOfLines = int.Parse(Console.ReadLine());

        while (numberOfLines != 0)
        {
            box.Add(new Box<string>(Console.ReadLine()));

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
