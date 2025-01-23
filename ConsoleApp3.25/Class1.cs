using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    public class Class1
    {
        private double _x;
        private double _a;
        private double _y;

        public Class1(double x, double a, double y)
        {
            _x = x;
            _a = a;
            _y = y;
        }
        public void J()
        {
            Console.WriteLine($"J={(Math.Pow(Math.Tan(Math.Pow(_a, 3)), 3) + Math.Pow(Math.Atan(_a), 2)) / (Math.Sqrt(Math.Pow(_y, Math.Tan(_x))))}");
        }
    }
}
