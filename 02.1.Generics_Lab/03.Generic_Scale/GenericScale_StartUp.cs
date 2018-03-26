/*
 * 03. Generic Scale
 * 
 * Create a class Scale<T> that holds two elements - left and right. The scale should receive 
 * the elements through its single constructor:
 * •   Scale(T left, T right)
 * The scale should have a single method: 
 * •   T GetHeavier()
 * The greater of the two elements is heavier. The method should return null if elements are equal.
 * 
 * https://github.com/PavelDoynov
 */


using System;


class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        Scale<int> scale = new Scale<int>(num1, num2);

        Console.WriteLine(scale.GetHeavier());
    }
}