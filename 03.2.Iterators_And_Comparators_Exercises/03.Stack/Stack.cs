using System;
using System.Collections;
using System.Collections.Generic;

public class Stack<T> : IEnumerable<T>
{
    private List<T> list;

    public Stack()
    {
        this.list = new List<T>();
    }

    public void Push(T item)
    {
        this.list.Add(item);
    }

    public T Pop()
    {
        if (this.list.Count > 0)
        {
            int index = this.list.Count - 1;
            T item = this.list[index];
            this.list.RemoveAt(index);
            return item;
        }
        else
        {
            throw new ArgumentException("No elements");
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.list.Count - 1; i >= 0; i--)
        {
            yield return this.list[i];
        }

        for (int i = this.list.Count - 1; i >= 0; i--)
        {
            yield return this.list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}