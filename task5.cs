using System;
using System.Collections.Generic;

public class MyList<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public T Get(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            return items[index];
        }
        throw new IndexOutOfRangeException("Invalid index");
    }
}

// გამოყენება:
MyList<int> intList = new MyList<int>();
intList.Add(10);
intList.Add(20);
intList.Add(30);

Console.WriteLine(intList.Get(1)); // ამობეჭდავს 20-ს
