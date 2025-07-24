using System;

class Program2
{
    static void Main()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
        {
            string input = Console.ReadLine();
            arr[i] = Convert.ToInt32(input);
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                if (arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        Console.WriteLine("Descending order:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine("\nMax: " + arr[0]);
        Console.WriteLine("Min: " + arr[9]);

        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            int num = Math.Abs(arr[i]);
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
        }

        Console.WriteLine("Sum of all digits: " + sum);
    }
}
