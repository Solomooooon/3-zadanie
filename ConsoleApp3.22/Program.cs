using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double F, x, y;

            Console.WriteLine("введите число - x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - y");
            y = Convert.ToDouble(Console.ReadLine());


            F = Math.Cos(Math.Pow(x, 2) + 2) + ((3.5 * Math.Pow(x, 2)+1)/(Math.Pow(Math.Cos(y),2)));

            Console.WriteLine($"F = {F}");
            Console.ReadLine();
        }
    }
}
