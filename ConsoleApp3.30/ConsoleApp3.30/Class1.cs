using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._30
{
    public class Class1
    {
        private double _x;
        public Class1(double x, double d, double y)
        {
            _x = x;
        }

        public void K()
        {
            Console.WriteLine($"K={(Math.Sqrt(Math.Pow((3 + _x), 6)) - Math.Log(_x)) / (Math.Exp(0) + Math.Asin(6 * Math.Pow(_x, 2)))}");
        }
    }
}
