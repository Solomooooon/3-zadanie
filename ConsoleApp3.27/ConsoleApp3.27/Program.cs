using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P, x, a, y, c;

            Console.WriteLine("введите число - a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - y");
            y = Convert.ToDouble(Console.ReadLine());

            P = (Math.Pow(a, 5) + Math.Acos(a + Math.Pow(x, 3)) - Math.Pow(Math.Sin(y - c), 4)) - (Math.Pow(Math.Sin(x + y), 3) + Math.Abs(x - y));

            Console.WriteLine($"P = {P}");
            Console.ReadLine();
        }
    }
}
