using System;

class Program1_1
{
    static void Main()
    {
        Console.Write("Enter first number (num1): ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number (num2): ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nBefore assignment : num1 = {num1}, num2 = {num2}");

        num2 = ++num1;

        Console.WriteLine($"\nAfter 'num2 = ++num1;' : num1 = {num1}, num2 = {num2}");
    }
}
