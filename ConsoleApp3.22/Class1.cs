using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public class Class1
    {
        private double _x;
        private double _y;

        public Class1(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public void F()
        {
            Console.WriteLine($"F={Math.Cos(Math.Pow(_x, 2) + 2) + ((3.5 * Math.Pow(_x, 2) + 1) / (Math.Pow(Math.Cos(_y), 2)))}");
        }
    }
}