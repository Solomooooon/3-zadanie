using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф6
{
    internal class Class1
    {
        private double _x;
        private double _b;
        private double _a;
        private double _y;

        public Class1(double x, double b, double a, double y)
        {
            _x = x;
            _b = b;
            _a = a;
            _y = y;
        }
        public void K()
        {
            Console.WriteLine($"K = {(Math.Sqrt(_x + _b - _a) + Math.Log(_y)) / Math.Atan(_b + _a)}");
        }
}
