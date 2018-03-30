using System;

public class Sorter<T>
    where T : IComparable<T>
{
    public static CustomPawelList<T> Sort(CustomPawelList<T> itemList)
    {
        CustomPawelList<T> newList = new CustomPawelList<T>();
        while (itemList.Count != 0)
        {
            int index = 0;
            T currentItem = itemList.Min();
            foreach (var item in itemList)
            {
                index++;
                if (item.CompareTo(currentItem) == 0)
                {
                    break;
                }
            }
            itemList.Remove(index - 1);
            newList.Add(currentItem);
        }
        return newList;
    }
}
