using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф2
{
    internal class Class1
    {
        private double _t;
        private double _c;
        private double _x;

        public Class1(double t, double c, double x)
        {
            _t = t;
            _c = c;
            _x = x;
        }
        public void L()
        {
            Console.WriteLine($"R = {Math.Pow(Math.Tan(_c), 2) + (2 * Math.Pow(_x, 2) + 5) / Math.Sqrt(_c + _t)}");
        }
    }
}
