using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф15
{
    internal class Class1
    {
        private double _y;
        private double _m;

        public Class1(double m, double y)
        {
            _y = y;
            _m = m;
        }
        public void N()
        {
            Console.WriteLine($"N = {(Math.Pow(_m, 2) + 2.8 * _m + 0.355) / (Math.Cos(2 * _y) + 3.6)}");
        }
}
