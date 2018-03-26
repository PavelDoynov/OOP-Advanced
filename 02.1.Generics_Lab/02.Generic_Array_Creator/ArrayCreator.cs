using System;

public class ArrayCreator
{
    public static T[] Create<T>(int length, T item)
    {
        T[] currentArr = new T[length];
        for (int i = 0; i < currentArr.Length; i++)
        {
            currentArr[i] = item;
        }
        return currentArr;
    }
}
