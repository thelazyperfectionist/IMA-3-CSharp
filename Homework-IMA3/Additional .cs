using System;

class Program
{
    static void Main()

        //1 - already done in DataStructures.cs.1?
    {
        //2-3
        int n = 124;  
        int firstDigit = n / 100;      
        int secondDigit = (n / 10) % 10; 
        int thirdDigit = n % 10;

        //the largest
        int largest = firstDigit;
        if (secondDigit > largest) largest = secondDigit;
        if (thirdDigit > largest) largest = thirdDigit;
        Console.WriteLine("Largest digit: " + largest);

        //the smallest 
        int smallest = firstDigit;
        if (secondDigit < smallest) smallest = secondDigit;
        if (thirdDigit < smallest) smallest = thirdDigit;
        Console.WriteLine("Smallest digit: " + smallest);

        //4
        int[] arr = { 1, 2, 3, 4, 5, 6 }; 
        int evenSum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                evenSum += arr[i];
            }
        }
        Console.WriteLine("Sum of even numbers: " + evenSum);

        //5
        int totalSum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            totalSum += arr[i];
        }
        double average = (double)totalSum / arr.Length;
        Console.WriteLine("Average of all numbers: " + average);
    }
}
