using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P, x, y, t;

            Console.WriteLine("введите число - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - x");
            x = Convert.ToDouble(Console.ReadLine());

            P = (Math.Pow(Math.Sin(x), 3) + Math.Log(2 * y + 3 * x)) / (Math.Pow(t, Math.Exp(1)) + Math.Sqrt(x));

            Console.WriteLine($"P = {P}");
            Console.ReadLine();
        }
    }
}
