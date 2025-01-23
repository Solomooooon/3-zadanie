using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double F, x, z, b, a;

            Console.WriteLine("введите число - z");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - a");
            a = Convert.ToDouble(Console.ReadLine());

            F = (Math.Sqrt(Math.Abs(x) + Math.Pow(Math.Cos(x), 3) + Math.Pow(z, 4))) / (Math.Log(x) - Math.Asin(b * x - a));

            Console.WriteLine($"F = {F}");
            Console.ReadLine();
        }
    }
}
