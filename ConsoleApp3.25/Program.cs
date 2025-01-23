using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double J, x, a, y;

            Console.WriteLine("введите число - a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - y");
            y = Convert.ToDouble(Console.ReadLine());

            J = (Math.Pow(Math.Tan(Math.Pow(a, 3)), 3) + Math.Pow(Math.Atan(a), 2)) / (Math.Sqrt(Math.Pow(y, Math.Tan(x))));

            Console.WriteLine($"J = {J}");
            Console.ReadLine();
        }
    }
    
}
