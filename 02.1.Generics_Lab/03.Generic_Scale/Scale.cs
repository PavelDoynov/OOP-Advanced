using System;

public class Scale<T>
    where T : IComparable<T>
{
    T item1;
    T item2;
    
    public Scale(T item1, T item2)
    {
        this.item1 = item1;
        this.item2 = item2;
    }

    public T GetHeavier()
    {
        if (this.item1.CompareTo(this.item2) > 0)
        {
            return this.item1;
        }
        else if (this.item1.CompareTo(this.item2) < 0)
        {
            return this.item2;
        }
        else
        {
            return default(T);
        }
    }
}