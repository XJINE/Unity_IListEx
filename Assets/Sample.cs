using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Sample : MonoBehaviour
{

    public List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    void Start()
    {
        this.list.Enqueue(10);
        DebugLog("Enque(10) : ");

        Debug.Log("Deque : " + this.list.Dequeue());
        DebugLog("Deque : ");

        Debug.Log("Peek : " + this.list.Peek());
        DebugLog("Peek : ");

        this.list.Push(11);
        DebugLog("Push(11) : ");

        Debug.Log("Pop : " + this.list.Pop());
        DebugLog("Pop : ");

        this.list.RemoveRange(0, 3);
        DebugLog("RemoveRange(0, 3) : ");

        this.list = this.list.Slice(3, 3).ToList();
        DebugLog("Slice(3, 3) : ");

        this.list.Shuffle();
        DebugLog("Shuffle : ");

        Debug.Log("Random : " + this.list.Random()
                        + "-" + this.list.Random()
                        + "-" + this.list.Random());
    }

    void DebugLog(string message)
    {
        foreach (var i in list) { message += i + ", "; }

        Debug.Log(message);
    }
}