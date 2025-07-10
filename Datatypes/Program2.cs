using System;

class Program2
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int digits = 0, letters = 0;

        foreach (char ch in input)
        {
            if (char.IsDigit(ch))
                digits++;
            else if (char.IsLetter(ch))
                letters++;
        }

        Console.WriteLine("Number of Alphabets: " + letters);
        Console.WriteLine("Number of Digits: " + digits);
    }
}
