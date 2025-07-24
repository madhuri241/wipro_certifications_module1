using System;
namespace Datatypes
{
    internal class Program4_3
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.Write("Enter a character to replace: ");
            char target = Console.ReadLine()[0];
            string replaced = str.Replace(target, '$');
            Console.WriteLine("After replacement: " + replaced);
        }
    }
}
