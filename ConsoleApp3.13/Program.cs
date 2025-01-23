using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, a, b, x;

            Console.WriteLine("Введите значение a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            R = (a / (x - a)) + ((Math.Pow(b, x) + Math.Pow(Math.Cos(x), 3)) / (Math.Pow(Math.Log(a), 3) + 4.5));
            Console.WriteLine($"R = {R}");

        }
    }
}
