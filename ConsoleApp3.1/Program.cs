using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double L, e, x, a, c;

            Console.WriteLine("Введите значение e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение c");
            c = Convert.ToDouble(Console.ReadLine());

            L = (Math.Sqrt(Math.Pow(e, x) - Math.Pow(Math.Cos(Math.Pow(x, 2) * Math.Pow(a, 5)), 4)) + Math.Pow(Math.Tan(a - Math.Pow(x, 5)), 4)) / (e * Math.Sqrt(Math.Abs(a + x * Math.Pow(c, 4))));
            Console.WriteLine($"L = {L}");

        }
    }
}
