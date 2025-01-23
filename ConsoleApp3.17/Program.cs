using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double T, x, y, b, a;

            Console.WriteLine("введите число - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - a");
            a = Convert.ToDouble(Console.ReadLine());

            T = (Math.Sqrt(x+b-a+Math.Log(y)))/(Math.Tan(b+a));

            Console.WriteLine($"T = {T}");
            Console.ReadLine();
        }
    }
}
