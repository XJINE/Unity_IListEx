# Unity_IListEx

IListEx provieds IList<T> extension methods.

*NOTE:* This project is made by Unity, but the ``IListEx.cs`` works on a native C#.

## Import to Your Project

You can import this asset from UnityPackage.

- [IListEx.unitypackage](https://github.com/XJINE/Unity_IListEx/blob/master/IListEx.unitypackage)

## How to Use

IListEx provies folloing methods.

```csharp
public static void Add<T>    (this IList<T> list, T item, int capacity)
public static void Enqueue<T>(this IList<T> list, T item)
public static void Enqueue<T>(this IList<T> list, T item, int capacity)
public static T    Dequeue<T>(this IList<T> list)
public static T    Peek<T>   (this IList<T> list)
public static void Push<T>   (this IList<T> list, T item)
public static void Push<T>   (this IList<T> list, T item, int capacity)
public static T    Pop<T>    (this IList<T> list)
public static void RemoveRange<T>(this IList<T> list, int index, int count)
public static IEnumerable<T> Slice<T>(this IList<T> list, int index, int count)
public static T    Random<T> (this IList<T> list)
public static void Shuffle<T>(this IList<T> list)
```