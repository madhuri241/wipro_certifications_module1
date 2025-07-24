using System;

class Program3
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = "";

        foreach (char ch in input)
        {
            if (char.IsLetter(ch))
            {
                char NewChar = (char)(ch + 1);
                if (char.IsUpper(ch))
                    NewChar = char.ToLower(NewChar);
                else
                    NewChar = char.ToUpper(NewChar);
                result += NewChar;
            }
            else
            {
                result += ch;
            }
        }

        Console.WriteLine("New string: " + result);
    }
}
