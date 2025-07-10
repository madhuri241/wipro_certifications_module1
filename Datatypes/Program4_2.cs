using System;
namespace Datatypes
{
    internal class Program4_2
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            string result = str.Substring(1);
            Console.WriteLine("Substring from 2nd character: " + result);
        }
    }
}
