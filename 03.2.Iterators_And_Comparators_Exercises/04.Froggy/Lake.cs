using System.Collections;
using System.Collections.Generic;

public class Lake<T> : IEnumerable<T>
{
    T[] arr;

    public Lake(T[] arrStones)
    {
        this.arr = arrStones;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.arr.Length; i += 2)
        {
            yield return this.arr[i];
        }

        int lastIndex;
        if (this.arr.Length % 2 == 0)
        {
            lastIndex = this.arr.Length - 1;
        }
        else
        {
            lastIndex = this.arr.Length - 2;
        }

        for (int i = lastIndex; i > 0; i -= 2)
        {
            yield return this.arr[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}