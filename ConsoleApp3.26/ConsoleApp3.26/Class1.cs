using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._26
{
    public class Class1
    {
        private double _x;
        private double _k;
        private double _y;

        public Class1(double x, double k, double y)
        {
            _x = x;
            _k = k;
            _y = y;
        }
        public void U()
        {
            Console.WriteLine($"J={(Math.Log(Math.Pow(_x, 3) + _y) - Math.Pow(_y, 4)) / (Math.Exp(_y) + 5.4 * Math.Pow(_k, 4))}");
        }
    }
}
