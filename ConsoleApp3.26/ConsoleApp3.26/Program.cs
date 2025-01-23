using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double U, x, k, y;

            Console.WriteLine("введите число - k");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - y");
            y = Convert.ToDouble(Console.ReadLine());

            U = (Math.Log(Math.Pow(x, 3) + y) - Math.Pow(y, 4)) / (Math.Exp(y) + 5.4 * Math.Pow(k, 4));

            Console.WriteLine($"U = {U}");
            Console.ReadLine();
        }
    }
}
