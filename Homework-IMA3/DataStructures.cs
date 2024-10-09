/* using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //1
        List<int> intList = new() { 1, 2, 3, 4, 5 }; //or intList.Add(1);...

        Console.Write("List: ");
        foreach (int num in intList)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        //2
        Dictionary<string, int> dict = new()
        {
            { "One", 1 },
            { "Two", 2 },
            { "Three", 3 },
            { "Four", 4 },
            { "Five", 5 }
        };

        Console.Write("Dictionary: ");
        foreach (KeyValuePair<string, int> kvp in dict)
        {
            Console.Write($"({kvp.Key}, {kvp.Value}) ");
        }
        Console.WriteLine();

        //3
        Queue<int> intQueue = new();

        intQueue.Enqueue(1);
        intQueue.Enqueue(2);
        intQueue.Enqueue(3);
        intQueue.Enqueue(4);
        intQueue.Enqueue(5);

        Console.Write("Queue: ");
        foreach (int num in intQueue)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        
        //4
        Stack<int> intStack = new();

        intStack.Push(1);
        intStack.Push(2);
        intStack.Push(3);
        intStack.Push(4);
        intStack.Push(5);

        Console.Write("Stack: ");
        foreach (int num in intStack)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
*/