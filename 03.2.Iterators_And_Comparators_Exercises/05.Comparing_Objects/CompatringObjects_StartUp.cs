/*
 * 05. Comparing Objects
 * 
 * There is a Comparable interface but you already know it. Your task is simple. Create a class Person.
 * Each person should have a name, an age and a town. You should implement the interface – IComparable<T> 
 * and implement the CompareTo method. When you compare two people, first you should compare their names,
 * after that – their age and finally – their towns.
 * 
 * Input
 * On every line, you will be given people in format:
 * {name} {age} {town}
 * Collect them till you receive "END"
 * After that, you will receive an integer N – the Nth person in your collection. Starting from 1.
 * 
 * Output
 * On the single output line, you should bring statistics, how many people are equal to him, how many people are
 * not equal to him and the total people in your collection.
 * 
 * Format: {number of equal people} {number of not equal people} {total number of people}
 * 
 * Constraints
 * Input names, ages and addresses will be valid. Input number will always be а valid integer in range [2…100]
 * If there are no equal people print: "No matches"
 * 
 * Example
 * Input:                  Output:
 * Pesho 22 Vraca          No matches
 * Gogo 14 Sofeto
 * END
 * 2
 * 
 * Input:                  Output:
 * Pesho 22 Vraca          2 1 3
 * Gogo 22 Vraca
 * Gogo 22 Vraca
 * END
 * 2
 * 
 * https://github.com/PavelDoynov
 */


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Person> personsList = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] inputArgs = input.Split(' ');
            personsList.Add(new Person(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2]));
        }

        Person personToCompare = personsList[int.Parse(Console.ReadLine()) - 1];

        int equals = 0;

        for (int i = 0; i < personsList.Count; i++)
        {
            if (personsList[i].CompareTo(personToCompare) == 1)
            {
                equals++;
            }
        }

        if (equals > 1)
        {
            Console.WriteLine($"{equals} {personsList.Count - equals} {personsList.Count}");
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
}
