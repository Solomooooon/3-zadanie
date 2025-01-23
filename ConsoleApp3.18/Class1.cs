using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    public class Class1
    {
        private double _t;
        private double _y;

        public Class1(double y, double t)
        {
            _t = t;
            _y = y;
        }
        public void S()
        {
            Console.WriteLine($"S={(4.351 * Math.Pow(_y, 3) + 2 * _t * Math.Log(_t)) / (Math.Sqrt(Math.Cos(2 * _y) + 4.351))}");
        }
    }
}
