using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._28
{
    public class Class1
    {
        private double _x;
        private double _z;
        private double _c;
        private double _y;
        public Class1(double x, double z, double c, double y)
        {
            _x = x;
            _z = z;
            _c = c;
            _y = y;
        }

        public void G()
        {
            Console.WriteLine($"G={(Math.Tan(Math.Pow(_x, 4) - 6) - Math.Pow(Math.Cos(_z + Math.Pow(_x, 3) + _y), 3 * _x)) / (Math.Pow(Math.Cos(Math.Pow(_x, 3) * Math.Pow(_c, 2)), 2))}");
        }
    }
}
