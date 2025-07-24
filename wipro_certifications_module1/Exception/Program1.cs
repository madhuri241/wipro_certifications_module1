using System;
public class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message)
    {
    }
}
class StudentMarks
{
    static void Main()
    {
        try
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter marks in Subject 1: ");
            int m1 = ReadMark();

            Console.Write("Enter marks in Subject 2: ");
            int m2 = ReadMark();

            Console.Write("Enter marks in Subject 3: ");
            int m3 = ReadMark();
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
            Console.WriteLine("\nFormat Error: Please enter only **integer values** for marks.");
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine("Invalid Input: " + ex.Message);
        }
    }

    static int ReadMark()
    {
        int mark = Convert.ToInt32(Console.ReadLine());
        if (mark < 0)
        {
            throw new NegativeNumberException("Marks cannot be negative.");
        }
        return mark;
    }
}
