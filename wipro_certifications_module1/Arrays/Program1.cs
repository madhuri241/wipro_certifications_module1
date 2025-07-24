using System;

class Program1
{
    static void Main()
    {
        int[] numbers = { 5, 10, 15, 20, 25 }; // sample array
        int count = 0;

        // Using foreach to manually count
        foreach (int num in numbers)
        {
            count++;
        }

        Console.WriteLine("Number of elements in the array: " + count);
    }
}
