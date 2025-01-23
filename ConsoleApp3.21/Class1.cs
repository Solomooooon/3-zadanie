using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    public class Class1
    {
        private double _x;
        private double _z;
        private double _a;

        public Class1(double x, double a, double z)
        {
            _x = x;
            _a = a;
            _z = z;
        }
        public void N()
        {
            Console.WriteLine($"N={(Math.Pow(Math.Sqrt(_z + Math.Sqrt(_z * _x)), 5)) / (Math.Exp(_x) + Math.Pow(_a, 5) * Math.Atan(_x))}");
        }
    }
}
