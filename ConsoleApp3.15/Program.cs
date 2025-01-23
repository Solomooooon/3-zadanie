using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N, m, y;

            Console.WriteLine("Введите значение m");
            m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            N = (Math.Pow(m, 2) +2.8 * m + 0.355) / (Math.Cos(2 * y) + 3.6);
            Console.WriteLine($"N = {N}");

        }
    }
}
