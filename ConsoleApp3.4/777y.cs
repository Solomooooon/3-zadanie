using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф4
{
    internal class _777y
    {
        private double _y;
        private double _x;

        public _777y(double y, double x)
        {
            _y = y;
            _x = x;
        }
        public void F()
        {
            Console.WriteLine($"F = {Math.Sqrt(Math.Pow((2 + _y), 2) + Math.Pow(Math.Sqrt(Math.Sin(_y + 5)), 7)) / (Math.Log(_x + 1) - Math.Pow(_y, 3))}");
        }
    }
}
