/*
 * 01. Box of T
 * 
 * Create a class Box<> that can store anything. 
 * It should have two public methods:
 * •   void Add(element)
 * •   element Remove()
 * •   int Count { get; }
 * 
 * Adding should add on top of its contents. Remove should get the topmost element.
 * 
 * Hints
 * Use the syntax Box<T> to create a generic class
 * 
 * https://github.com/PavelDoynov
 */


using System;

class Program
{
    static void Main(string[] args)
    {
        Box<int> box = new Box<int>();
        box.Add(1);
        box.Add(2);
        box.Add(3);
        Console.WriteLine(box.Remove());
        box.Add(4);
        box.Add(5);
        Console.WriteLine(box.Remove());

    }
}