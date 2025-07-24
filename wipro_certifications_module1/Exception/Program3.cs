using System;

namespace WiproCertifications
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public void GetDetailsFromUser()
        {
            try
            {
                Console.Write("Enter Name: ");
                Name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Name))
                    throw new ArgumentNullException("Name cannot be empty.");

                Console.Write("Enter Age: ");
                Age = int.Parse(Console.ReadLine());

                Console.Write("Enter Email: ");
                Email = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Email))
                    throw new ArgumentNullException("Email cannot be empty.");

                Console.WriteLine("\nPerson Details:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Email: {Email}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format. Age must be a number.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Input Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong: " + ex.Message);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Person person = new Person();
            person.GetDetailsFromUser();
        }
    }
}
