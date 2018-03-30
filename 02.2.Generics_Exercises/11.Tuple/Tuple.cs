using System;

public class Tuple<T1, T2>
{
    T1 item1;
    T2 item2;


    public Tuple(T1 item1, T2 item2)
    {
        this.item1 = item1;
        this.item2 = item2;
    }

	public override string ToString()
	{
        return $"{this.item1} -> {this.item2}";
	}
}
