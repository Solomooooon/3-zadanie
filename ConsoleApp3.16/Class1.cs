using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    public class Class1
    {
        private double _x;
        private double _t;
        private double _y;

        public Class1(double x, double t, double y)
        {
            _x = x;
            _t = t;
            _y = y;
        }
        public void P()
        {
            Console.WriteLine($"G={(Math.Pow(Math.Sin(_x), 3) + Math.Log(2 * _y + 3 * _x)) / (Math.Pow(_t, Math.Exp(1)) + Math.Sqrt(_x))}");
        }
    }
}
