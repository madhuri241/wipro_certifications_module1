using System;

public class Person
{
    private string firstName;
    private string lastName;
    private string email;
    private DateTime dateOfBirth;

    
    public Person(string firstName, string lastName, string email, DateTime dateOfBirth)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.dateOfBirth = dateOfBirth;
    }

   
    public bool IsAdult
    {
        get
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (dateOfBirth > DateTime.Now.AddYears(-age)) age--;
            return age >= 18;
        }
    }

    public string SunSign
    {
        get
        {
            int day = dateOfBirth.Day;
            int month = dateOfBirth.Month;

            return (month, day) switch
            {
                (1, <= 19) => "Capricorn",
                (1, _) => "Aquarius",
                (2, <= 18) => "Aquarius",
                (2, _) => "Pisces",
                (3, <= 20) => "Pisces",
                (3, _) => "Aries",
                (4, <= 19) => "Aries",
                (4, _) => "Taurus",
                (5, <= 20) => "Taurus",
                (5, _) => "Gemini",
                (6, <= 20) => "Gemini",
                (6, _) => "Cancer",
                (7, <= 22) => "Cancer",
                (7, _) => "Leo",
                (8, <= 22) => "Leo",
                (8, _) => "Virgo",
                (9, <= 22) => "Virgo",
                (9, _) => "Libra",
                (10, <= 22) => "Libra",
                (10, _) => "Scorpio",
                (11, <= 21) => "Scorpio",
                (11, _) => "Sagittarius",
                (12, <= 21) => "Sagittarius",
                (12, _) => "Capricorn",
                _ => "Unknown"
            };
        }
    }

    public bool IsBirthDay
    {
        get => dateOfBirth.Month == DateTime.Now.Month && dateOfBirth.Day == DateTime.Now.Day;
    }

    public string ScreenName
    {
        get
        {
            string dobPart = dateOfBirth.ToString("MMddyy");
            string screen = $"{firstName.Substring(0, 1).ToLower()}{lastName.ToLower()}{dobPart}";
            return screen;
        }
    }

    public string FullName => $"{firstName} {lastName}";
    public string Email => email;
    public DateTime DateOfBirth => dateOfBirth;
}

public class Employee : Person
{
    public double Salary { get; }

    public Employee(string firstName, string lastName, string email, DateTime dob, double salary)
        : base(firstName, lastName, email, dob)
    {
        Salary = salary;
    }
}
public class Program1
{
    public static void Main()
    {
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter Date of Birth (yyyy-mm-dd): ");
        DateTime dob = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee emp = new Employee(firstName, lastName, email, dob, salary);

        Console.WriteLine($"\n--- Employee Info ---");
        Console.WriteLine($"Full Name     : {emp.FullName}");
        Console.WriteLine($"Email         : {emp.Email}");
        Console.WriteLine($"Date of Birth : {emp.DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Salary        : {emp.Salary}");
        Console.WriteLine($"Is Adult      : {emp.IsAdult}");
        Console.WriteLine($"Sun Sign      : {emp.SunSign}");
        Console.WriteLine($"Is Birthday   : {emp.IsBirthDay}");
        Console.WriteLine($"Screen Name   : {emp.ScreenName}");
    }
}
