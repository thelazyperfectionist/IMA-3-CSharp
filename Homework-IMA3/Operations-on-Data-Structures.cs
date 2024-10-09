/* using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //1. 
        List<int> intList = new List<int> { 1, 2, 3, 4, 5 };

        int sumList = 0;
        foreach (int num in intList)
        {
            sumList += num;
        }
        Console.WriteLine("Sum of list elements: " + sumList);

        //2. 
        Dictionary<string, int> dict = new Dictionary<string, int>
        {
            { "One", 1 },
            { "Two", 2 },
            { "Three", 3 },
            { "Four", 4 },
            { "Five", 5 }
        };

        int sumDict = 0;
        foreach (KeyValuePair<string, int> kvp in dict)
        {
            sumDict += kvp.Value;
        }
        Console.WriteLine("Sum of dictionary values: " + sumDict);

        //3.
        Queue<int> intQueue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });

        intQueue.Dequeue();
        intQueue.Dequeue();

        Console.WriteLine("Remaining elements in the queue:");
        foreach (int num in intQueue)
        {
            Console.WriteLine(num);
        }

        //4.
        Stack<int> intStack = new Stack<int>(new[] { 1, 2, 3, 4, 5 });

        intStack.Pop();
        intStack.Pop();

        Console.WriteLine("Remaining elements in the stack:");
        foreach (int num in intStack)
        {
            Console.WriteLine(num);
        }
    }
} */