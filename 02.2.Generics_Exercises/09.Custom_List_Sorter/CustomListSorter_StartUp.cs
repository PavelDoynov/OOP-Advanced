/*
 * 09. Custom List Sorter
 * 
 * Extend the previous problem by creating an additional Sorter class. It should have a single static method Sort() 
 * which can sort objects of type CustomList containing any type that can be compared. Extend the command list to
 * support one additional command Sort:
 * 
 * •    Sort - Sort the elements in the list in ascending order.
 * 
 * Example
 * Input:      Output:
 * Add cc      aa
 * Add bb      bb
 * Add aa      cc
 * Sort
 * Print
 * END
 * 
 * https://github.com/PavelDoynov
 */


using System;
using System.Linq;

class CustomListSorter_StartUp
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
            else if (cmd == "Sort")
            {
                list = Sorter<string>.Sort(list);
            }
            else if (cmd == "Print")
            {
                //list.Print(); - We can use this method! 
                foreach (var item in list)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
