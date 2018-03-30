/*
 * 07. Generic Count Method Doubles
 * 
 * Use the description of the previous problem but now, test your list of generic boxes with doubles.
 * 
 * Example
 * Input           Output
 * 3               2
 * 7.13
 * 123.22
 * 42.78
 * 7.55
 * 
 * https://github.com/PavelDoynov
 */


using System;
using System.Collections.Generic;

class GenericCountMethodDoubles_StartUp
{
    static void Main(string[] args)
    {
        int numberOfLines = int.Parse(Console.ReadLine());

        List<double> box = new List<double>();

        while (numberOfLines != 0)
        {
            box.Add(double.Parse(Console.ReadLine()));
            numberOfLines--;
        }

        double compareTo = double.Parse(Console.ReadLine());

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
