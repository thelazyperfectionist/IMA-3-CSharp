using System;
using System.Collections.Generic;

/* class MergeSort
{
    public static void MergeSortArray(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSortArray(array, left, mid);
            MergeSortArray(array, mid + 1, right);
            Merge(array, left, mid, right);
        }
    }

    public static void Merge(int[] array, int left, int mid, int right)
    {
        int leftSize = mid - left + 1;
        int rightSize = right - mid;
        int[] leftArray = new int[leftSize];
        int[] rightArray = new int[rightSize];

        Array.Copy(array, left, leftArray, 0, leftSize);
        Array.Copy(array, mid + 1, rightArray, 0, rightSize);

        int i = 0, j = 0;
        int k = left;
        while (i < leftSize && j < rightSize)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        while (i < leftSize)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }

        while (j < rightSize)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 38, 27, 43, 3, 9, 82, 10 };
        Console.WriteLine("Original array:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        MergeSortArray(array, 0, array.Length - 1);

        Console.WriteLine("\nSorted array:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
} */

class SimpleDataTracker
{
    private Dictionary<int, string> data = new Dictionary<int, string>();

    public void AddOrUpdate(int key, string value)
    {
        if (data.ContainsKey(key))
        {
            data[key] = value;
            Console.WriteLine($"Key {key} {value}");
        }
        else
        {
            data[key] = value;
            Console.WriteLine($"Key {key} {value}");
        }
    }

    public string GetValue(int key)
    {
        return data.TryGetValue(key, out string value) ? value : "Key not found!";
    }

    public void ShowAllData()
    {
        Console.WriteLine("\nCurrent data:");
        foreach (var pair in data)
        {
            Console.WriteLine($"Key {pair.Key}: {pair.Value}");
        }
    }

    public void Remove(int key)
    {
        if (data.Remove(key))
        {
            Console.WriteLine($"Key {key} removed.");
        }
        else
        {
            Console.WriteLine($"There is no {key} to be removed.");
        }
    }
}

class Program
{
    static void Main()
    {
        SimpleDataTracker tracker = new SimpleDataTracker();

        tracker.AddOrUpdate(1, "Toyota");
        tracker.AddOrUpdate(2, "Honda");
        tracker.AddOrUpdate(3, "Ford");

        Console.WriteLine("Value for key 2: " + tracker.GetValue(2));

        tracker.AddOrUpdate(2, "Chevrolet");
        tracker.AddOrUpdate(4, "BMW");

        tracker.ShowAllData();

        tracker.Remove(3);
    }
}