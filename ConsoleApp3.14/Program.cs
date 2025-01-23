using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, x;

            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());
          

            R = (Math.Pow(Math.Sin(Math.Pow(x, 2) + 4), 3) + 4.33) / (Math.Pow(Math.Sin(Math.Pow(x, 4)), 3));
            Console.WriteLine($"R = {R}");
        }
    }
}
