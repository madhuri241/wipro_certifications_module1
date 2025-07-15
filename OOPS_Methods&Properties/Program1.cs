using System;
public class Employee
{
    string emp_Name;
    double basic_Salary,HRA,DA,TAX,gross_Pay,net_Salary;
    public Employee(string emp_Name, double basic_Salary)
    {
        this.emp_Name = emp_Name;
        this.basic_Salary = basic_Salary;
        
    }
    public void CalculateSalary()
    {
        HRA = basic_Salary * 0.15;
        DA = basic_Salary * 0.10;
        gross_Pay = basic_Salary + HRA + DA;
        TAX = gross_Pay * 0.08;
        net_Salary = gross_Pay - TAX;
    }
    public void DisplaySalary()
    {
        Console.WriteLine("Employee Name: " + emp_Name);
        Console.WriteLine("Basic Salary: " + basic_Salary);
        Console.WriteLine("HRA: " + HRA);
        Console.WriteLine("DA: " + DA);
        Console.WriteLine("Gross Pay: " + gross_Pay);
        Console.WriteLine("TAX: " + TAX);
        Console.WriteLine("Net Salary: " + net_Salary);
    }
}
public class Program
{
    public static void Main()
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Basic Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Employee emp = new Employee(name, salary);
        emp.CalculateSalary();
        emp.DisplaySalary();
    }
}