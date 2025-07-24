using System;

class Program1
{
    static void Main()
    {
        string correctLogin = "admin";
        string correctPassword = "password123";
        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter login: ");
            string login = Convert.ToString(Console.ReadLine());

            Console.Write("Enter password: ");
            string password = Convert.ToString(Console.ReadLine());

            if (login == correctLogin && password == correctPassword)
            {
                Console.WriteLine("Login successful!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid login or password.");
                attempts++;
            }
        }

        Console.WriteLine("Too many failed attempts. Access denied.");
    }
}
