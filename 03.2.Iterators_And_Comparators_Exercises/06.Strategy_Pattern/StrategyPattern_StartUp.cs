/*
 * 06. Strategy Pattern
 * 
 * An interesting pattern you may have heard of is the Strategy Pattern, if we have multiple ways to do a task
 * (say sort a collection) it allows the client to choose the way that fits his needs the most. A famous implementation
 * of the pattern in C# are the List<T>.Sort() and Array.Sort() methods that take an IComparer as an argument.
 * 
 * Create a class Person that holds a name and an age. Create 2 Comparators for Person 
 * (classes which implement the IComparer<Person> interface). The first comparator should compare people based on the
 * length of their name as a first parameter, if 2 people have a name with the same length, perform a case-insensitive 
 * compare based on the first letter of their name instead. The second comparator should compare them based on their age.
 * 
 * Create 2 SortedSets of type Person, the first should implement the name comparator and the second should implement 
 * the age comparator.
 * 
 * Input
 * On the first line of input you will receive a number N. On each of the next N lines you will receive information 
 * about people in the format “<name> <age>”.  Add the people from the input into both sets (both sets should hold 
 * all the people passed in from the input).
 * 
 * Output
 * Foreach the sets and print each person from the set on a new line in the same format that you received them. Start
 * with the set that implements the name comparator.
 * 
 * Constraints
 * •   A person’s name will be a string that contains only alphanumerical characters with a length between [1…50] symbols.
 * •   A person’s age will be a positive integer between [1…100].
 * •   The number of people N will be a positive integer between [0…100].
 * 
 * Example
 * Input:       Output:                Input:       Output:
 * 3            Joro 100               5            asen 33
 * Pesho 20     Pesho 20               Ivan 17      Ivan 17
 * Joro 100     Pencho 1               asen 33      Joro 3
 * Pencho 1     Pencho 1               Stoqn 25     Nasko 99
 *              Pesho 20               Nasko 99     Stoqn 25
 *              Joro 100               Joro 3       Joro 3
 *                                                  Ivan 17
 *                                                  Stoqn 25
 *                                                  asen 33
 *                                                  Nasko 99
 * 
 * https://github.com/PavelDoynov
 */


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        SortedSet<Person> compareByName = new SortedSet<Person>(new NameComparator());
        SortedSet<Person> compareByAge = new SortedSet<Person>(new AgeComparator()); 

        int counter = int.Parse(Console.ReadLine());

        while (counter != 0)
        {
            string[] inputArgs = Console.ReadLine().Split(' ');

            compareByAge.Add(new Person(inputArgs[0], int.Parse(inputArgs[1])));
            compareByName.Add(new Person(inputArgs[0], int.Parse(inputArgs[1])));

            counter--;
        }

        foreach (var person in compareByName)
        {
            Console.WriteLine($"{person.Name} {person.Age}");
        }

        foreach (var person in compareByAge)
        {
            Console.WriteLine($"{person.Name} {person.Age}");
        }
    }
}
