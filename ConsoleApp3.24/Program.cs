using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f, x, z, b, a;

            Console.WriteLine("введите число - z");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - a");
            a = Convert.ToDouble(Console.ReadLine());

            f = (Math.Pow(Math.Cos(b * Math.Pow(x, 5)), 7) - (Math.Sin(Math.Pow(a, 2)) + Math.Cos(Math.Pow(x, 3) + Math.Pow(z, 5) - Math.Pow(a, 2)))) / (Math.Asin(Math.Pow(a,2))+Math.Acos(Math.Pow(x,7)-Math.Pow(a,5)));

            Console.WriteLine($"f = {f}");
            Console.ReadLine();
        }
    }
}
