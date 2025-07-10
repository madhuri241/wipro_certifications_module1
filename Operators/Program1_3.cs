using System;

class Program1_3
{
    static void Main()
    {
        Console.Write("Enter first number : ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number : ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nBefore swapping : a = {a}, b = {b}");

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"\nAfter swapping : a = {a}, b = {b}");
    }
}
