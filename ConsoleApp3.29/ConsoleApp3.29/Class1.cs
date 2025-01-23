using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._29
{
    public class Class1
    {
        private double _x;
        private double _d;
        private double _y;
        public Class1(double x, double d, double y)
        {
            _x = x;
            _d = d;
            _y = y;
        }

        public void R()
        {
            Console.WriteLine($"R={(Math.Pow(Math.Cos(_y), 2) + 2.4 * _d) / (Math.Exp(_y) + Math.Log(Math.Pow(Math.Sin(_x), 2) + 6))}");
        }
    }
}
