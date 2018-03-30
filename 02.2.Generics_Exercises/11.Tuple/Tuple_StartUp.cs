/*
 * 11. Tuple
 * 
 * There is something, really annoying in C#. It is called a Tuple. It is a class, which may store a few objects but let’s
 * focus on the type of Tuple which contains two objects. The first one is “item1” and the second one is “item2”. 
 * It is kind of like a KeyValuePair except – it simply has items, which are neither key nor value. The annoyance is 
 * coming from the fact, that you have no idea what these objects are holding. The class name is telling you 
 * nothing, the methods which it has – also. So, let’s say for some reason we would like to try to implement it by ourselves.
 * 
 * The task: Create a class “Tuple”, which is holding two objects. Like we said, the first one, will be “item1” and the
 * second one - “item2”. The tricky part here is to make the class hold generics. This means, that when you create a new
 * object of class - “Tuple”, there should be a way to explicitly, specify both the items type separately.
 * 
 * Input
 * The input consists of three lines:
 * •    The first one is holding a person name and an address. They are separated by space(s). 
 *      Your task is to collect them in the tuple and print them on the console. Format of the input:
 *      <<first name> <last name>> <address>
 * •   The second line holds a name of a person and the amount of beer (int) he can drink. Format:
 *     <name> <liters of beer>
 * •   The last line will hold an Integer and a Double. Format:
 *     <Integer> <Double>
 * 
 * Output
 * •   Print the tuples’ items in format: {item1} -> {item2}
 * 
 * Constraints
 * Use the good practices we have learned. Create the class and make it have getters and setters for its class variables.
 * The input will be valid, no need to check it explicitly!
 * 
 * Example
 * Input:                         Output:
 * Sofka Tripova Stolipinovo      Sofka Tripova -> Stolipinovo
 * Az 2                           Az -> 2
 * 23 21.23212321                 23 -> 21.23212321
 * 
 * https://github.com/PavelDoynov
 */


using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] inputArgs = Console.ReadLine().Split(' ').ToArray();
        string name = $"{inputArgs[0]} {inputArgs[1]}";
        string town = inputArgs[2];
        Tuple<string, string> tupleOne = new Tuple<string, string>(name, town);
        Console.WriteLine(tupleOne);

        string[] inputArgs2 = Console.ReadLine().Split(' ').ToArray();
        Console.WriteLine(new Tuple<string, int>(inputArgs2[0], int.Parse(inputArgs2[1])));

        double[] inputArgs3 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        Console.WriteLine(new Tuple<double, double>(inputArgs3[0], inputArgs3[1]));
    }
}
