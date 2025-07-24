using System;

namespace EmployeeInterfaceDemo
{
    public interface IPayable
    {
        decimal CalculatePay();
    }

    public class Employee
    {
        public string Name { get; set; }
    }

    public class HourlyEmployee : Employee, IPayable
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public HourlyEmployee(string name, decimal hourlyRate, int hoursWorked)
        {
            Name = name;
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public decimal CalculatePay()
        {
            return HourlyRate * HoursWorked;
        }
    }

    public class PermanentEmployee : Employee, IPayable
    {
        public decimal MonthlySalary { get; set; }

        public PermanentEmployee(string name, decimal monthlySalary)
        {
            Name = name;
            MonthlySalary = monthlySalary;
        }

        public decimal CalculatePay()
        {
            return MonthlySalary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Hourly Employee Details");
            Console.Write("Name: ");
            string hourlyName = Console.ReadLine();
            Console.Write("Hourly Rate: ");
            decimal hourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Hours Worked: ");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());

            IPayable hourlyEmployee = new HourlyEmployee(hourlyName, hourlyRate, hoursWorked);

            Console.WriteLine("\nEnter Permanent Employee Details");
            Console.Write("Name: ");
            string permName = Console.ReadLine();
            Console.Write("Monthly Salary: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            IPayable permanentEmployee = new PermanentEmployee(permName, salary);

            Console.WriteLine("\n--- Salary Details ---");
            Console.WriteLine($"Hourly Employee {hourlyName} Pay: {hourlyEmployee.CalculatePay()}");
            Console.WriteLine($"Permanent Employee {permName} Pay: {permanentEmployee.CalculatePay()}");

            Console.ReadLine();
        }
    }
}
