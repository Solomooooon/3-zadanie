using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф9
{
    internal class Class1
    {

        private double _y;
        private double _d;
        private double _x;

        public Class1(double y, double d, double x)
        {
            _y = y;
            _d = d;
            _x = x;
        }
        public void R()
        {
            Console.WriteLine($"R = {(Math.Pow(Math.Cos(_y), 3) + Math.Pow(2, _x) * _d) / (Math.Exp(_y) + Math.Log(Math.Pow(Math.Sin(_x), 2) + 7.4))}");
        }
    }
}
