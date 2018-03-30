/*
 * 03. Generic Box Of Integer
 * 
 * Use the description of the previous problem but now, test your generic box with Integers.
 * 
 * Example
 * Input           Output
 * 3               System.Int32: 7
 * 7               System.Int32: 123
 * 123             System.Int32: 42
 * 42
 * 
 * https://github.com/PavelDoynov
 */
 

using System;

class GenericBoxOfInteger_StartUp
{
    static void Main(string[] args)
    {
        int numberOfLines = int.Parse(Console.ReadLine());

        while (numberOfLines != 0)
        {
            Console.WriteLine(new Box<int>(int.Parse(Console.ReadLine())));

            numberOfLines--;
        }
    }
}
