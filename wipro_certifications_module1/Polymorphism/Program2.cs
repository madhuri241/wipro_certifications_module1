using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class calculator
    {
               public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Subtract(int a, int b, int c)
        {
            return a - b - c;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return (double)a / b;
        }

        public double Divide(int a, int b, int c)
        {
            if (b == 0 || c == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return (double)a / b / c;
        }
    }
    internal class Program2
    {
        static void Main(string[] args)
        {
            calculator calc = new calculator();
            Console.WriteLine("Addition of 2 numbers: " + calc.Add(5, 10));
            Console.WriteLine("Addition of 3 numbers: " + calc.Add(5, 10, 15));
            Console.WriteLine("Subtraction of 2 numbers: " + calc.Subtract(10, 5));
            Console.WriteLine("Subtraction of 3 numbers: " + calc.Subtract(20, 10, 5));
            Console.WriteLine("Multiplication of 2 numbers: " + calc.Multiply(5, 10));
            Console.WriteLine("Multiplication of 3 numbers: " + calc.Multiply(2, 3, 4));
            Console.WriteLine("Division of 2 numbers: " + calc.Divide(10, 2));
            Console.WriteLine("Division of 3 numbers: " + calc.Divide(100, 5, 2));
        }
    }
}
