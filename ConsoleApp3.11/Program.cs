using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double I, y, x;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            I = (2.33 * Math.Log(Math.Sqrt(1 + Math.Pow(Math.Cos(y), 2)))) / (Math.Exp(y) + Math.Pow(Math.Sin(x), 2));
            Console.WriteLine($"I = {I}");

        }
    }
}
