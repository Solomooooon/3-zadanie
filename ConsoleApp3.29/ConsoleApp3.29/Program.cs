using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, x, d, y;

            Console.WriteLine("введите число - d");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - y");
            y = Convert.ToDouble(Console.ReadLine());

            R = (Math.Pow(Math.Cos(y), 2) + 2.4 * d) / (Math.Exp(y) + Math.Log(Math.Pow(Math.Sin(x), 2) + 6));

            Console.WriteLine($"R = {R}");
            Console.ReadLine();
        }
    }
}
