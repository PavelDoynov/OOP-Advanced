using System;
using System.Text;

public class CustomPawelList<T>
    where T : IComparable<T>
{
    T[] arrList;
    int indexCounter;

    public CustomPawelList()
    {
        arrList = new T[4];
        indexCounter = 0;
    } 

    public void Add(T element)
    {
        arrList[indexCounter] = element;
        indexCounter++;

        if (indexCounter + 1 == arrList.Length)
        {
            arrList = MultiplyArrList();
        }
    }

    private T[] MultiplyArrList()
    {
        T[] newArr = new T[this.arrList.Length * 2];
        for (int i = 0; i < this.arrList.Length; i++)
        {
            newArr[i] = arrList[i];
        }
        return newArr;
    }

    public T Remove(int index)
    {
        T currentItem = this.arrList[index];
        for (int i = index; i < this.arrList.Length - 1; i++)
        {
            this.arrList[i] = this.arrList[i + 1];
        }
        indexCounter--;
    
        if (indexCounter <= this.arrList.Length / 3)
        {
            this.arrList = ShrinkArrList();
        }
        return currentItem;
    }

    private T[] ShrinkArrList()
    {
        T[] newArr = new T[this.arrList.Length / 3];
        for (int i = 0; i < this.indexCounter; i++)
        {
            newArr[i] = this.arrList[i];
        }
        return newArr;
    }

    public bool Contains(T element)
    {
        bool containsElement = false;
        for (int i = 0; i < this.indexCounter; i++)
        {
            if (this.arrList[i].CompareTo(element) == 0)
            {
                containsElement = true;
                break;
            }
        }
        return containsElement;
    }

    public void Swap(int index1, int index2)
    {
        T currentElement = this.arrList[index1];
        this.arrList[index1] = this.arrList[index2];
        this.arrList[index2] = currentElement;
    }

    public int CountGreaterThan(T element)
    {
        int currentCount = 0;
        for (int i = 0; i < this.indexCounter; i++)
        {
            if (this.arrList[i].CompareTo(element) > 0)
            {
                currentCount++;
            }
        }
        return currentCount;
    }

    public T Max()
    {
        T currentItem = this.arrList[0];
        for (int i = 0; i <this.indexCounter; i++)
        {
            if (this.arrList[i].CompareTo(currentItem) > 0)
            {
                currentItem = this.arrList[i];
            }
        }
        return currentItem;
    }

    public T Min()
    {
        T currentItem = this.arrList[0];
        for (int i = 0; i < this.indexCounter; i++)
        {
            if (this.arrList[i].CompareTo(currentItem) < 0)
            {
                currentItem = this.arrList[i];
            }
        }
        return currentItem;
    }

    public void Print()
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < this.indexCounter; i++)
        {
            result.AppendLine(this.arrList[i].ToString());
        }
        Console.WriteLine(result.ToString().Trim());
    }
}
