using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
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
        public void f()
        {
            Console.WriteLine($"f={(Math.Pow(Math.Cos(_b * Math.Pow(_x, 5)), 7) - (Math.Sin(Math.Pow(_a, 2)) + Math.Cos(Math.Pow(_x, 3) + Math.Pow(_z, 5) - Math.Pow(_a, 2)))) / (Math.Asin(Math.Pow(_a, 2)) + Math.Acos(Math.Pow(_x, 7) - Math.Pow(_a, 5)))}");
        }
    }
}
