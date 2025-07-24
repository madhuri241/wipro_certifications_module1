using System;

class Program2
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number (single digit): ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        if ((num1 / 1) % 10 == num2)
        {
            Console.WriteLine($"{num2} is in one's place.");
            found = true;
        }

        if ((num1 / 10) % 10 == num2)
        {
            Console.WriteLine($"{num2} is in ten's place.");
            found = true;
        }

        if ((num1 / 100) % 10 == num2)
        {
            Console.WriteLine($"{num2} is in hundred's place.");
            found = true;
        }

        if ((num1 / 1000) % 10 == num2)
        {
            Console.WriteLine($"{num2} is in thousand's place.");
            found = true;
        }

        if (!found)
        {
            Console.WriteLine($"{num2} is not present in one's, ten's, hundred's, or thousand's place.");
        }
    }
}
