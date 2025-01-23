using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public class Class1
    {
        private double _x;
        private double _a;
        private double _b;
        private double _z;

        public Class1(double x, double a, double z, double b)
        {
            _x = x;
            _a = a;
            _b = b;
            _z = z;
        }
        public void F()
        {
            Console.WriteLine($"F={(Math.Sqrt(Math.Abs(_x) + Math.Pow(Math.Cos(_x), 3) + Math.Pow(_z, 4))) / (Math.Log(_x) - Math.Asin(_b * _x - _a))}");
        }
    }
}
