using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф11
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
        public void I()
        {
            Console.WriteLine($"I = {(2.33 * Math.Log(Math.Sqrt(1 + Math.Pow(Math.Cos(_y), 2)))) / (Math.Exp(_y) + Math.Pow(Math.Sin(_x), 2))}");
        }
    }
}
