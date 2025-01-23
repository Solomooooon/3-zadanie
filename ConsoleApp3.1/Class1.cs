using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф1
{
    internal class Class1
    {
        private double _e;
        private double _x;
        private double _a;
        private double _c;

        public Class1(double e, double x, double a, double c)
        {
            _e = e;
            _x = x;
            _a = a;
            _c = c;
        }
        public void L()
        {
            Console.WriteLine($"L = {(Math.Sqrt(Math.Pow(_e, _x) - Math.Pow(Math.Cos(Math.Pow(_x, 2) * Math.Pow(_a, 5)), 4)) + Math.Pow(Math.Tan(_a - Math.Pow(_x, 5)), 4)) / (_e * Math.Sqrt(Math.Abs(_a + _x * Math.Pow(_c, 4))))}");
        }
    }
}
