using System;
class Person1
{
    private string firstName;
    private string lastName;
    private string email;
    private DateTime dateOfBirth;

    public Person1(string firstName, string lastName, string email, DateTime dateOfBirth)
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

    public bool IsBirthDay => dateOfBirth.Month == DateTime.Now.Month && dateOfBirth.Day == DateTime.Now.Day;

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

public class Employee1 : Person1
{
    public double Salary { get; }

    public Employee1(string firstName, string lastName, string email, DateTime dob, double salary)
        : base(firstName, lastName, email, dob)
    {
        Salary = salary;
    }
}

public class HourlyEmployee : Person1
{
    public double HoursWorked { get; set; }
    public double PayPerHour { get; set; }

    public double TotalPay => HoursWorked * PayPerHour;

    public HourlyEmployee(string firstName, string lastName, string email, DateTime dob, double hoursWorked, double payPerHour)
        : base(firstName, lastName, email, dob)
    {
        HoursWorked = hoursWorked;
        PayPerHour = payPerHour;
    }
}

public class PermanentEmployee : Person
{
    public double HRA { get; set; }
    public double DA { get; set; }
    public double Tax { get; set; }

    public double TotalPay => HRA + DA;
    public double NetPay => TotalPay - Tax;

    public PermanentEmployee(string firstName, string lastName, string email, DateTime dob, double hra, double da, double tax)
        : base(firstName, lastName, email, dob)
    {
        HRA = hra;
        DA = da;
        Tax = tax;
    }

}

public class Program1
{
    public static void Main()
    {
        Console.WriteLine("------ Hourly Employee ------");
        HourlyEmployee hourlyEmp = new HourlyEmployee("Priya", "Verma", "priya.verma@example.com", new DateTime(2002, 6, 15), 45, 300);
        Console.WriteLine($"Full Name     : {hourlyEmp.FullName}");
        Console.WriteLine($"Email         : {hourlyEmp.Email}");
        Console.WriteLine($"DOB           : {hourlyEmp.DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Is Adult      : {hourlyEmp.IsAdult}");
        Console.WriteLine($"Sun Sign      : {hourlyEmp.SunSign}");
        Console.WriteLine($"Is Birthday   : {hourlyEmp.IsBirthDay}");
        Console.WriteLine($"Total Pay     : {hourlyEmp.TotalPay}");
        Console.WriteLine($"Screen Name   : {hourlyEmp.ScreenName}");
        Console.WriteLine();

        Console.WriteLine("------ Permanent Employee ------");
        PermanentEmployee permEmp = new PermanentEmployee("Karan", "Mehta", "karan.mehta@example.com", new DateTime(1998, 12, 5), 10000, 7000, 2000);
        Console.WriteLine($"Full Name     : {permEmp.FullName}");
        Console.WriteLine($"Email         : {permEmp.Email}");
        Console.WriteLine($"DOB           : {permEmp.DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Is Adult      : {permEmp.IsAdult}");
        Console.WriteLine($"Sun Sign      : {permEmp.SunSign}");
        Console.WriteLine($"Is Birthday   : {permEmp.IsBirthDay}");
        Console.WriteLine($"Total Pay     : {permEmp.TotalPay}");
        Console.WriteLine($"Tax           : {permEmp.Tax}");
        Console.WriteLine($"Net Pay       : {permEmp.NetPay}");
        Console.WriteLine($"Screen Name   : {permEmp.ScreenName}");
    }
}
