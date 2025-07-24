using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the file name (with .txt extension): ");
        string fileName = Console.ReadLine();

        Console.WriteLine("Enter the content to write into the file:");
        string content = Console.ReadLine();

        try
        {
            // Write content to the file
            File.WriteAllText(fileName, content);
            Console.WriteLine("File created and content saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while creating the file:");
            Console.WriteLine(ex.Message);
        }
    }
}
