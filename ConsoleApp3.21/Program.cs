using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double  N, x, a, z;

            Console.WriteLine("введите число - b");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - c");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число - a");
            a = Convert.ToDouble(Console.ReadLine());

            N = (Math.Pow(Math.Sqrt(z+Math.Sqrt(z*x)),5))/(Math.Exp(x)+Math.Pow(a,5)*Math.Atan(x));

            Console.WriteLine($"N = {N}");
            Console.ReadLine();
        }
    }
}
