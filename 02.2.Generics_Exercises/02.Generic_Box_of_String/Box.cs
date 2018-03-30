using System;


public class Box<T>
{
    T item;

    public Box(T item)
    {
        this.item = item;
    }

    public override string ToString()
    {
        return $"{this.item.GetType().FullName}: {this.item}";
    }
}
