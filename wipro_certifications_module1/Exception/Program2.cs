using System;
using System.Text.RegularExpressions;

class Person
{
	private string firstName;
	private string lastName;
	private string email;
	private DateTime dateOfBirth;

	public Person(string firstName, string lastName, string email, DateTime dateOfBirth)
	{
		if (string.IsNullOrWhiteSpace(firstName) || !Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
			throw new ArgumentException("First name cannot be empty and must contain only alphabets.");

		if (string.IsNullOrWhiteSpace(lastName) || !Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
			throw new ArgumentException("Last name cannot be empty and must contain only alphabets.");

		if (string.IsNullOrWhiteSpace(email))
			throw new ArgumentNullException("Email cannot be empty.");

		if (dateOfBirth > DateTime.Now || dateOfBirth < DateTime.Now.AddYears(-130))
			throw new ArgumentOutOfRangeException("Date of birth is not valid.");

		this.firstName = firstName;
		this.lastName = lastName;
		this.email = email;
		this.dateOfBirth = dateOfBirth;
	}

	public void DisplayPerson()
	{
		Console.WriteLine("----- Person Details -----");
		Console.WriteLine($"Name : {firstName} {lastName}");
		Console.WriteLine($"Email: {email}");
		Console.WriteLine($"DOB  : {dateOfBirth.ToShortDateString()}");
	}
}

class Program
{
	static void Main(string[] args)
	{
		try
		{
			Console.Write("Enter First Name: ");
			string fName = Console.ReadLine();

			Console.Write("Enter Last Name: ");
			string lName = Console.ReadLine();

			Console.Write("Enter Email: ");
			string email = Console.ReadLine();

			Console.Write("Enter Date of Birth (yyyy-mm-dd): ");
			string dobInput = Console.ReadLine();
			DateTime dob = DateTime.ParseExact(dobInput, "yyyy-MM-dd", null);

			Person person = new Person(fName, lName, email, dob);
			person.DisplayPerson();
		}
		catch (FormatException)
		{
			Console.WriteLine("Format Error: Invalid date format. Use yyyy-mm-dd.");
		}
		catch (ArgumentNullException ex)
		{
			Console.WriteLine("Null Error: " + ex.Message);
		}
		catch (ArgumentOutOfRangeException ex)
		{
			Console.WriteLine("Range Error: " + ex.Message);
		}
		catch (ArgumentException ex)
		{
			Console.WriteLine("Argument Error: " + ex.Message);
		}
		catch (Exception ex)
		{
			Console.WriteLine("Unexpected Error: " + ex.Message);
		}
	}
}
