/*
 * 03. Stack
 * 
 * Since you have passed the basic algorithms course, now you have a task to create your custom stack. You are aware 
 * of the Stack's structure. There is a collection to store the elements and two functions (not from the functional
 * programming) - to push an element and to pop it. Keep in mind that the first element which is popped is the last 
 * in the collection. The push method adds an element to the top of the collection and the pop method returns the 
 * top element and removes it.
 * 
 * Write your custom implementation of Stack<T> and implement IEnumerable<T> interface. Your implementation of the
 * GetEnumerator() method should follow the rules of the Abstract Data Type – Stack (return the elements in reverse
 * order of adding them to the stack).
 * 
 * Input
 * The input will come from the console as lines of commands. Commands will only be push and pop, followed by integers
 * for the push command and no another input for the pop command.
 * 
 * Format:
 * •   Push {element1}, {element2}, … {elementN} – add given elements to the stack.
 * •   Pop – removes the last pushed element from the stack.
 * 
 * Output
 * When you receive END, the input is over. Foreach the stack twice and print all elements each on new line.
 * 
 * Constraints
 * •   The elements in the push command will be valid integers between [2-32…232-1].
 * •   The commands will always be valid (always be either Push, Pop or END).
 * •   If Pop command could not be executed as expected (e.g. no elements in the stack), print on the console: "No elements".
 * 
 * Example
 * Input:             Output:                    Input:             Output:
 * Push 1, 2, 3, 4    2                          Push 1, 2, 3, 4    1
 * Pop                1                          Pop                3
 * Pop                2                          Push 1             2
 * END                1                          END                1
 *                                                                  1 
 *                                                                  3
 * Input:                 Output:                                   2
 * Push 1, 2, 3, 4        No elements                               1
 * Pop
 * Pop
 * Pop
 * Pop
 * Pop
 * END
 * 
 * https://github.com/PavelDoynov
 */


using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> stack = new Stack<string>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] inputArgs = input.Split(' ');
            string cmd = inputArgs[0];
            inputArgs = inputArgs.Skip(1).ToArray();


            if (cmd == "Push")
            {
                cmd = string.Concat(inputArgs);
                inputArgs = cmd.Split(',');
                for (int i = 0; i < inputArgs.Length; i++)
                {
                    stack.Push(inputArgs[i]);
                }
            }
            else if (cmd == "Pop")
            {
                try
                {
                    stack.Pop();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}
