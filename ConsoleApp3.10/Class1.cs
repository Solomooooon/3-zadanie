using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф10
{
    internal class Class1
    {
        private double _x;
        private double _y;

        public Class1(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public void U()
        {
            Console.WriteLine($"U = {(Math.Exp(Math.Pow(_x, 3)) + (Math.Pow(Math.Cos(_x - 4), 2)) / Math.Atan(_x) + 5.2 * _y)}");
        }
    }
}
