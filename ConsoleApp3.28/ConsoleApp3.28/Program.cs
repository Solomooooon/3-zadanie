using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double G, x, z, y, c;

            Console.WriteLine("введите число - z");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - y");
            y = Convert.ToDouble(Console.ReadLine());

            G = (Math.Tan(Math.Pow(x, 4) - 6) - Math.Pow(Math.Cos(z + Math.Pow(x, 3) + y), 3 * x)) / (Math.Pow(Math.Cos(Math.Pow(x, 3) * Math.Pow(c, 2)), 2));

            Console.WriteLine($"G = {G}");
            Console.ReadLine();
        }
    }
}
