using System;

namespace EmployeePaymentApp
{
    public interface IPayable
    {
        decimal CalculatePay();
    }

    public class HourlyEmployee : IPayable
    {
        public string Name { get; set; }
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

    public class PermanentEmployee : IPayable
    {
        public string Name { get; set; }
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
            IPayable emp1 = new HourlyEmployee("Alice", 200.50m, 40);
            IPayable emp2 = new PermanentEmployee("Bob", 55000.00m);

            Console.WriteLine("Employee Payment Details:");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Hourly Employee Pay (Alice): {emp1.CalculatePay()}");
            Console.WriteLine($"Permanent Employee Pay (Bob): {emp2.CalculatePay()}");

            Console.ReadLine();
        }
    }
}
