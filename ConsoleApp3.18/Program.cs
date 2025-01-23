using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S,  y, t;

            Console.WriteLine("введите число - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - t");
            t = Convert.ToDouble(Console.ReadLine());

            S = (4.351 * Math.Pow(y, 3) + 2 * t * Math.Log(t)) / (Math.Sqrt(Math.Cos(2 * y) + 4.351));

            Console.WriteLine($"S = {S}");
            Console.ReadLine();
        }
    }
}
