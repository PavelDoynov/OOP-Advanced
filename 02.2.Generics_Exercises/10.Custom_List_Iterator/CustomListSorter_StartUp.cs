/*
 * 10. Custom List Iterator
 * 
 * For the print command, you have probably used a for loop. Extend your custom list class by making it implement 
 * IEnumerable<T>. This should allow you to iterate your list in a foreach statement.
 * 
 * Example
 * Input:           Output:
 * Add aa           cc
 * Add bb           aa
 * Add cc           2
 * Max              cc
 * Min              bb
 * Greater aa       aa
 * Swap 0 2
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
