using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double D, x, y, a;

            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение a");
            a = Convert.ToDouble(Console.ReadLine());
            
            D = (Math.Cos(Math.Pow(x, 3) + 6) - Math.Sin(y - a)) / Math.Log(Math.Pow(x, 4)) - 2 * Math.Pow(Math.Sin(x), 5) ;
            Console.WriteLine($"D = {D}");

        }
    }
}
