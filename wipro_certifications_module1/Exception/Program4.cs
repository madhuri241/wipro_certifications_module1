using System;

class program4 
{
    static void Main()
    {
        try
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter marks in Subject 1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Subject 2: ");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Subject 3: ");
            int m3 = Convert.ToInt32(Console.ReadLine());

            int total = m1 + m2 + m3;
            double average = total / 3.0;

            Console.WriteLine("\nStudent Name: " + name);
            Console.WriteLine("Subject 1 Marks: " + m1);
            Console.WriteLine("Subject 2 Marks: " + m2);
            Console.WriteLine("Subject 3 Marks: " + m3);
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Average: " + average);
        }
        catch (FormatException)
        {
            Console.WriteLine("\nError: Please enter **only integer values** for marks.");
        }
    }
}

