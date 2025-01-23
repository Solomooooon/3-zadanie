using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._19
{
    public class Class1
    {
        private double _a;
        private double _K;
        private double _x;
        private double _b;
        private double _y;

        public Class1(double y, double K, double b, double x, double a)
        {
            _a = a;
            _K = K;
            _b = b;
            _x = x;
            _y = y;
        }
        public void D()
        {
            Console.WriteLine($"S={(Math.Pow(_K, -_a * _b) - _a * Math.Sqrt(6) - Math.Cos(3 * _a * _b)) / Math.Pow(Math.Sin(_a * Math.Asin(_x + Math.Log(_y))), 2)}");
        }
    }
}
