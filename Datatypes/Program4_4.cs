using System;
namespace Datatypes
{
    internal class Program4_4
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string original = Console.ReadLine();
            string copied = string.Copy(original);
            if (copied.Length > 1)
            {
                char[] chars = copied.ToCharArray();
                chars[2] = '*';
                copied = new string(chars);
            }

            Console.WriteLine("Original String: " + original);
            Console.WriteLine("Modified  String: " + copied);

        }
    }
}

