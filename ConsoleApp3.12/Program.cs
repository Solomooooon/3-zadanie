using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double G, x, y, a;

            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение a");
            a = Convert.ToDouble(Console.ReadLine());

            G = (Math.Pow(Math.Cos(Math.Abs(y + x)), 3) - (x + y)) / Math.Pow(Math.Atan(x + a), 4) * Math.Pow(x, 5);
            Console.WriteLine($"G = {G}");

        }
    }
}
