using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class Class1
    {
        private double _x;
        private double _a;
        private double _b;
        private double _y;

        public Class1(double x, double a, double y, double b)
        {
            _x = x;
            _a = a;
            _b = b;
            _y = y;
        }
        public void T()
        {
            Console.WriteLine($"T={(Math.Sqrt(_x + _b - _a + Math.Log(_y))) / (Math.Tan(_b + _a))}");
        }
    }
}