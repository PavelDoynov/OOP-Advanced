using System;
using System.Collections.Generic;

public class Box<T>
{
    List<T> collection;

    public Box()
    {
        this.collection = new List<T>();
    }

    public int Count { get { return this.collection.Count; } }

    public void Add(T element)
    {
        this.collection.Insert(0, element);
    }

    public T Remove()
    {
        T element = this.collection[0];
        this.collection.RemoveAt(0);
        return element;
    }
}