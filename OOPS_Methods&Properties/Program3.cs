using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Methods_Properties
{
    public class RandomHelper
    {
        public static int GetRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public static double GetRandomDouble(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }

    }
    public class Program3
    {
        static void Main(string[] args)
        {
            int randomInt = RandomHelper.GetRandomNumber(1, 100);
            Console.WriteLine($"Random Integer: {randomInt}");
            double randomDouble = RandomHelper.GetRandomDouble(1.0, 100.0);
            Console.WriteLine($"Random Double: {randomDouble:F2}");
        }
    }
}
