using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double L, c, x, t;

            Console.WriteLine("Введите значение c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение t");
            t = Convert.ToDouble(Console.ReadLine());

            L = (Math.Pow(Math.Tan(c), 2) + (2 * Math.Pow(x, 2) + 5)) / Math.Sqrt(c + t);
            Console.WriteLine($"L =  {L}");
        }
    }
}
