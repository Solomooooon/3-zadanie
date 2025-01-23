using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._27
{
    public class Class1
    {
        private double _x;
        private double _a;
        private double _c;
        private double _y;
        public Class1(double x, double a, double c, double y)
        {
            _x = x;
            _a = a;
            _c = c;
            _y = y;
        }

        public void P()
        {
            Console.WriteLine($"P={(Math.Pow(_a, 5) + Math.Acos(_a + Math.Pow(_x, 3)) - Math.Pow(Math.Sin(_y - _c), 4)) - (Math.Pow(Math.Sin(_x + _y), 3) + Math.Abs(_x - _y))}");
        }
    }
}
