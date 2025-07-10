using System;

namespace Datatypes
{
    internal class Program4_1
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            string RevStr = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                RevStr += str[i];
            }

            Console.WriteLine("Reversed string: " + RevStr);
        }
    }
}
