using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P, a, y, c, x;

            Console.WriteLine("Введите значение a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            P = (Math.Pow(a, 5) + Math.Pow(Math.Sin(y - c), 4)) / (Math.Pow(Math.Sin(x + y), 3) + Math.Abs(x - y));
            Console.WriteLine($"P = {P}");
        }
    }
}
