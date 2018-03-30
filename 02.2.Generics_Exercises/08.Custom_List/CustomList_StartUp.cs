/*
 * 08. Custom List
 * 
 * Create a generic data structure that can store any type that can be compared. 
 * Implement functions:
 *   - void Add(T element)
 *   - T Remove(int index)
 *   - bool Contains(T element)
 *   - void Swap(int index1, int index2)
 *   - int CountGreaterThan(T element)
 *   - T Max()
 *   - T Min()
 *   
 *   Create a command interpreter that reads commands and modifies the custom list that you have created.
 *   Set the custom list’s type to string. Implement the commands:
 *   -  Add <element> - Adds the given element to the end of the list
 *   -  Remove <index> - Removes the element at the given index
 *   -  Contains <element> - Prints if the list contains the given element (True or False)
 *   -  Swap <index> <index> - Swaps the elements at the given indexes
 *   -  Greater <element> - Counts the elements that are greater than the given element and prints their count
 *   -  Max - Prints the maximum element in the list
 *   -  Min - Prints the minimum element in the list
 *   -  Print - Prints all elements in the list, each on a separate line
 *   -  END - stops the reading of commands
 *   -  There will not be any invalid input commands.
 *   
 *   Exaple
 *   Input:               Output:
 *   Add aa               cc
 *   Add bb               aa
 *   Add cc               2
 *   Max                  True
 *   Min                  cc
 *   Greater aa           bb
 *   Swap 0 2             aa2
 *   Contains aa
 *   Print
 *   END
 *   
 * https://github.com/PavelDoynov
 */ 


using System;
using System.Linq;

class CustomList_StartUp
{
    static void Main(string[] args)
    {
        CustomPawelList<string> list = new CustomPawelList<string>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] cmdArgs = input.Split(' ').ToArray();
            string cmd = cmdArgs[0];

            if (cmd == "Add")
            {
                list.Add(cmdArgs[1]);
            }
            else if (cmd == "Remove")
            {
                list.Remove(int.Parse(cmdArgs[1]));
            }
            else if (cmd == "Contains")
            {
                if (list.Contains(cmdArgs[1]))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (cmd == "Swap")
            {
                int firstIndex = int.Parse(cmdArgs[1]);
                int secondIndex = int.Parse(cmdArgs[2]);
                list.Swap(firstIndex, secondIndex);
            }
            else if (cmd == "Greater")
            {
                Console.WriteLine(list.CountGreaterThan(cmdArgs[1]));
            }
            else if (cmd == "Max")
            {
                Console.WriteLine(list.Max());
            }
            else if (cmd == "Min")
            {
                Console.WriteLine(list.Min());
            }
            else if (cmd == "Print")
            {
                list.Print();
            }
        }

    }
}
