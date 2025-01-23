using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фаф5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double G, x, z, y, c; 

            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение z");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение c");
            c = Convert.ToDouble(Console.ReadLine());


            G = (Math.Tan(Math.Pow(x, 4) - 6) - Math.Pow(Math.Cos(z + x * y), 3)) / (Math.Pow(Math.Cos(Math.Pow(x, 3) * Math.Pow(c, 2)), 4));
            Console.WriteLine($"G = {G}");

        }
    }
}
