using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double D, K, y, x, a, b;

            Console.WriteLine("введите число - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - K");
            K = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - b");
            b = Convert.ToDouble(Console.ReadLine());

            D = (Math.Pow(K, -a * b) - a * Math.Sqrt(6) - Math.Cos(3 * a * b)) / Math.Pow(Math.Sin(a * Math.Asin(x + Math.Log(y))), 2);

            Console.WriteLine($"D = {D}");
            Console.ReadLine();
        }
    }
}
