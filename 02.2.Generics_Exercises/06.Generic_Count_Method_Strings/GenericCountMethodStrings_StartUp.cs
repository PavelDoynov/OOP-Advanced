/*
 * 06. Generic Count Method Strings
 * 
 * Create a method that receives as argument a list of any type that can be compared and an element of the given type. 
 * The method should return the count of elements that are greater than the value of the given element. Modify your
 * Box class to support comparing by value of the data stored.
 * On the first line, you will receive n - the number of elements to add to the list. On the next n lines, you will
 * receive the actual elements. On the last line, you will get the value of the element to which you need to compare
 * every element in the list.
 * 
 * Example
 * Input       Output
 * 3           2
 * aa
 * aaa
 * bb
 * aa
 * 
 * https://github.com/PavelDoynov
 */ 


using System;
using System.Collections.Generic;

class GenericCountMethodStrings_StartUp
{
    static void Main(string[] args)
    {
        int numberOfLines = int.Parse(Console.ReadLine());

        List<string> box = new List<string>();

        while (numberOfLines != 0)
        {
            box.Add(Console.ReadLine());
            numberOfLines--;
        }

        string compareTo = Console.ReadLine();

        Console.WriteLine(Compare(box, compareTo));
    }

    private static int Compare<T>(List<T> box, T compare)
        where T : IComparable<T>
    {
        int result = 0;

        for (int i = 0; i < box.Count; i++)
        {
            if (box[i].CompareTo(compare) > 0)
            {
                result++;
            }
        }

        return result;
    }
}
