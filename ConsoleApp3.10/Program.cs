using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double U, x, y;

            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            U = (Math.Exp(Math.Pow(x, 3)) + (Math.Pow(Math.Cos(x - 4), 2)) / Math.Atan(x) + 5.2 * y);
            Console.WriteLine($"U = {U}");
        }
    }
}
