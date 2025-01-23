using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                double A, y, h;

                Console.WriteLine("Введите значение y");
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение h");
                h = Convert.ToDouble(Console.ReadLine());

                A = (Math.Tan(Math.Pow(y, 3) - Math.Pow(h, 4)) + Math.Pow(h, 2)) / (Math.Pow(Math.Sin(h), 2) + y);

                Console.WriteLine($"A = {A}");
        }
    }
}
