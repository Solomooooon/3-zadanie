using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фаф5
{
    internal class Class1
    {
        private double _x;
        private double _z;
        private double _y;
        private double _c;

        public Class1(double x, double z, double y, double c)
        {
            _x = x;
            _z = z;
            _y = y;
            _c = c;
        }
        public void G()
        {
            Console.WriteLine($"G = {(Math.Tan(Math.Pow(_x, 4) - 6) - Math.Pow(Math.Cos(_z + _x * _y), 3)) / (Math.Pow(Math.Cos(Math.Pow(_x, 3) * Math.Pow(_c, 2)), 4))}");
        }
    }
}
