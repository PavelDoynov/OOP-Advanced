/*
 * 12. Threeuple
 * 
 * Create a Class Threeuple. Its name is telling us, that it will hold no longer, just a pair of objects. The task is 
 * simple, our Threeuple should hold three objects. Make it have getters and setters. You can even extend the previous
 * class.
 * 
 * Input
 * The input consists of three lines:
 * •   The first one is holding a name, an address and a town. Format of the input:
 *     <<first name> <last name>> <address> <town>
 * •   The second line is holding a name, beer liters, and a Boolean variable with value - drunk or not. Format:
 *     <name> <liters of beer> <drunk or not>
 * •   The last line will hold a name, a bank balance (double) and a bank name. Format:
 *     <name> <account balance> <bank name>
 * 
 * Output
 * •   Print the Threeuples’ objects in format: {firstElement} -> {secondElement} -> {thirdElement}
 * 
 * Example
 * Input:                                         Output:
 * Sofka Tripova Stolipinovo Plovdiv              Sofka Tripova -> Stolipinovo -> Plovdiv
 * MitkoShtaigata 18 drunk                        MitkoShtaigata -> 18 -> True
 * SashoKompota 0.10 NkqfaBanka                   SashoKompota -> 0.1 -> NkqfaBanka
 * 
 * Input:                                         Output:
 * Ivan Ivanov Tepeto Plovdiv                     Ivan Ivanov -> Tepeto -> Plovdiv
 * Mitko 18 not                                   Mitko -> 18 -> False
 * Sasho 0.10 NGB                                 Sasho -> 0.1 -> NGB
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
        Console.WriteLine(new Threeuple<string, string, string>($"{inputArgs[0]} {inputArgs[1]}",
                                                                inputArgs[2], inputArgs[3]));

        string[] inputArgs2 = Console.ReadLine().Split(' ').ToArray();
        if (GetArg3(inputArgs2[2]))
        {
            Console.WriteLine(new Threeuple<string, int, string>(inputArgs2[0], int.Parse(inputArgs2[1]), "True"));
        }
        else
        {
            Console.WriteLine(new Threeuple<string, int, string>(inputArgs2[0], int.Parse(inputArgs2[1]), "False"));
        }

        string[] inputArgs3 = Console.ReadLine().Split(' ').ToArray();
        Console.WriteLine(new Threeuple<string, double, string>(inputArgs3[0], double.Parse(inputArgs3[1]), inputArgs3[2]));
    }

    private static bool GetArg3(string v)
    {
        if (v == "drunk")
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}