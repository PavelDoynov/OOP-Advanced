/*
 * 02. Generic Box Of String
 * 
 * Use the class that you've created for the previous problem and test it with the class System.String. On the first line, 
 * you will get n - the number of strings to read from the console. On the next n lines, you will get the actual strings. 
 * For each of them create a box and call its ToString() method to print its data on the console.
 * 
 * Example
 * Input                 Output
 * 2                     System.String: life in a box
 * life in a box         System.String: box in a life
 * box in a life
 * 
 * https://github.com/PavelDoynov
 */ 


using System;

class GenericBoxOfString_StartUp
{
    static void Main(string[] args)
    {
        int numberOfLines = int.Parse(Console.ReadLine());

        while (numberOfLines != 0)
        {
            Console.WriteLine(new Box<string>(Console.ReadLine()));

            numberOfLines--;
        }
    }
}
