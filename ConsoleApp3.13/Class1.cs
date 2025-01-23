using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф13
{
    internal class Class1
    {

        private double _a;
        private double _b;
        private double _x;

        public Class1(double a, double b, double x)
        {
            _a = a;
            _b = b;
            _x = x;
        }
        public void R()
        {
            Console.WriteLine($"R = {(_a / (_x - _a)) + ((Math.Pow(_b, _x) + Math.Pow(Math.Cos(_x), 3)) / (Math.Pow(Math.Log(_a), 3) + 4.5))}");
        }
    }
}
