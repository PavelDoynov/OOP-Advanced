using System.Collections.Generic;
using System;
using System.Linq;
using System.Collections;

public class ListyIterator<T> : IEnumerable<T>
{
    List<T> list;
    int index;

    public ListyIterator()
    {
        list = new List<T>();
        index = 0;
    }

    public void Create(T[] arr)
    {
        this.list = arr.ToList();
    }

    public bool Move()
    {
        if (HasNext())
        {
            this.index++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool HasNext()
    {
        if (this.index + 1 < this.list.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Print()
    {
        if (this.list.Count > 0)
        {
            Console.WriteLine(this.list[this.index]);
        }
        else
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.list.Count; i++)
        {
            yield return this.list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
