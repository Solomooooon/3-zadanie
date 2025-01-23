using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double K, x;

            Console.WriteLine("введите число - x");
            x = Convert.ToDouble(Console.ReadLine());

            K = (Math.Sqrt(Math.Pow((3 + x), 6)) - Math.Log(x)) / (Math.Exp(0) + Math.Asin(6 * Math.Pow(x, 2)));

            Console.WriteLine($"K = {K}");
            Console.ReadLine();
        }
    }
}
