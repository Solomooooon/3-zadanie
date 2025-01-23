using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double K, x, b, a, y;

            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            K = (Math.Sqrt(x + b - a) + Math.Log(y)) / Math.Atan(b + a);
            Console.WriteLine($"K = {K}");

        }
    }
}
