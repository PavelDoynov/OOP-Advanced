/*
 * 01. ListyIterator
 * 
 * Create a generic class "ListyIterator", it should receive the collection which it will iterate over, 
 * through its constructor. You should store the elements in a List. The class should have three main functions:
 * 
 * •    Move - should move an internal index position to the next index in the list, the method should return true 
 *      if it successfully moved and false if there is no next index.
 * •    HasNext - should return true if there is a next index and false if the index 
 *      is already at the last element of the list.
 * •   Print - should print the element at the current internal index, calling Print on a collection without elements
 *     should throw an appropriate exception with the message "Invalid Operation!". 
 * 
 * By default, the internal index should be pointing to the 0th index of the List. Your program should support the
 * following commands:
 * 
 * Command:                Return Type:         Description:
 * Create {e1 e2 …}        void                 Creates a ListyIterator from the specified collection. In case of a 
 *                                              Create command without any elements, you should create a 
 *                                              ListyIterator with an empty collection.
 * 
 * Command:                Return Type:         Description:
 * Move                    boolean              This command should move the internal index to the next index.
 * 
 * Command:                Return Type:         Description:
 * Print                   void                 This command should print the element at the current internal index.
 * 
 * Command:                Return Type:         Description:
 * HasNext                 boolean              Returns whether the collection has a next element.
 * 
 * Command:                Return Type:         Description:
 * END                     void                 Stops the input.
 * 
 * 
 * Input:
 * Input will come from the console as lines of commands. The first line will always be the only Create command in the
 * input. The last command received will always be the only END command.
 * 
 * Output:
 * For every command from the input (with the exception of the END and Create commands) print the result of that 
 * command on the console, each on a new line. In case of Move or HasNext commands print the return value of the methods,
 * in case of a Print command you don’t have to do anything additional as the method itself should already print on the
 * console. Your program should catch any exceptions thrown because of validations (calling Print on an empty collection)
 * and print their messages instead.
 * 
 * Constraints:
 * •    There will always be only 1 Create command and it will always be the first command passed.
 * •    The number of commands received will be between [1…100].
 * •    The last command will always be the only END command.
 * 
 * Example:
 * Input:         Output:                            Input:                          Output:
 * Create         Invalid Operation!                 Create Stefcho Goshky           True
 * Print                                             HasNext                         Stefcho
 * END                                               Print                           True
 *                                                   Move                            Goshky
 *                                                   Print
 *                                                   END
 * 
 * Input:            Output:
 * Create 1 2 3      True
 * HasNext           True
 * Move              True
 * HasNext           True
 * HasNext           True
 * Move              False
 * HasNext
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
        ListyIterator<string> listy = new ListyIterator<string>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] inputArgs = input.Split(' ');
            string cmd = inputArgs[0];
            if (cmd == "Create")
            {
                listy.Create(inputArgs.Skip(1).ToArray());
            }
            else if (cmd == "HasNext")
            {
                if (listy.HasNext())
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (cmd == "Move")
            {
                if (listy.Move())
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (cmd == "Print")
            {
                try
                {
                    listy.Print();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}