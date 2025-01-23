using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф7
{
    internal class Class1
    {

        private double _x;
        private double _y;
        private double _a;

        public Class1(double x, double y, double a)
        {
            _x = x;
            _y = y;
            _a = a;
        }
        public void D()
        {
            Console.WriteLine($"D = {(Math.Cos(Math.Pow(_x, 3) + 6) - Math.Sin(_y - _a)) / Math.Log(Math.Pow(_x, 4)) - 2 * Math.Pow(Math.Sin(_x), 5)}");
        }
    }
}
