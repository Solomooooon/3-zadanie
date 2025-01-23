using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, x, b, U, a, y;

            Console.WriteLine("введите число - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - a");
            a = Convert.ToDouble(Console.ReadLine());

            U = (Math.Pow(Math.Tan(y),3)+Math.Pow(Math.Sin(x*Math.Sqrt(b-c)),5))/(Math.Sqrt(a-b+c));

            Console.WriteLine($"U = {U}");
            Console.ReadLine();
        }
    }
}
