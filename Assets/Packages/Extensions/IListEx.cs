using System.Collections.Generic;
using System.Linq;

public static class IListEx
{
    #region Field

    private static System.Random RandomGenerator;

    #endregion Field

    #region Constructor

    static IListEx()
    {
        RandomGenerator = new System.Random(System.DateTime.Now.Millisecond);
    }

    #endregion Constructor

    #region Method

    public static void Add<T>(this IList<T> list, T item, int capacity)
    {
        list.Add(item);
        
        int removeCount = list.Count - capacity;

        if (removeCount > 0)
        {
            RemoveRange(list, 0, removeCount);
        }
    }

    public static void Enqueue<T>(this IList<T> list, T item)
    {
        list.Add(item);
    }

    public static void Enqueue<T>(this IList<T> list, T item, int capacity)
    {
        Add(list, item, capacity);
    }

    public static T Dequeue<T>(this IList<T> list)
    {
        T value = list[0];
        list.RemoveAt(0);
        return value;
    }

    public static T Peek<T>(this IList<T> list)
    {
        return list[0];
    }

    public static void Push<T>(this IList<T> list, T item)
    {
        list.Insert(0, item);
    }

    public static void Push<T>(this IList<T> list, T item, int capacity)
    {
        list.Insert(0, item);

        int listCount   = list.Count;
        int removeCount = listCount - capacity;
        int index       = listCount - removeCount - 1;

        RemoveRange(list, index, removeCount);
    }

    public static T Pop<T>(this IList<T> list)
    {
        return Dequeue(list);
    }

    public static void RemoveRange<T>(this IList<T> list, int index, int count)
    {
        var removes = list.Skip(index).Take(count);
        list = (IList<T>)list.Except(removes);
    }

    public static IEnumerable<T> Slice<T>(this IList<T> list, int index, int count)
    {
        return list.Skip(index).Take(count);
    }

    public static T Random<T>(this IList<T> list)
    {
        return list[RandomGenerator.Next(list.Count)];
    }

    public static void Shuffle<T>(this IList<T> list)
    {
        int count = list.Count;
        int index;

        while (count > 1)
        {
            count--;

            index = RandomGenerator.Next(count + 1);

            T value     = list[index];
            list[index] = list[count];
            list[count] = value;
        }
    }

    #endregion Method
}