using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double F, y, x;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            F = Math.Sqrt(Math.Pow((2 + y), 2) + Math.Pow(Math.Sqrt(Math.Sin(y + 5)), 7))  / (Math.Log(x + 1) - Math.Pow(y, 3));
            Console.WriteLine($"F = {F}");
        }
    }
}
