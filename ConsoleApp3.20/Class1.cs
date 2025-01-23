using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    public class Class1
    {
        private double _x;
        private double _c;
        private double _a;
        private double _b;
        private double _y;

        public Class1(double x, double a, double y, double b, double c)
        {
            _x = x;
            _a = a;
            _b = b;
            _y = y;
            _c = c;
        }
        public void D()
        {
            Console.WriteLine($"D={(Math.Pow(Math.Tan(_y), 3) + Math.Pow(Math.Sin(_x * Math.Sqrt(_b - _c)), 5)) / (Math.Sqrt(_a - _b + _c))}");
        }
    }
}
