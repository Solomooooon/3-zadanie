using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, y, d, x;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение d");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            R = (Math.Pow(Math.Cos(y), 3) + Math.Pow(2, x) * d) / (Math.Exp(y) + Math.Log(Math.Pow(Math.Sin(x), 2) + 7.4));
            Console.WriteLine($"R = {R}");

        }
    }
}
