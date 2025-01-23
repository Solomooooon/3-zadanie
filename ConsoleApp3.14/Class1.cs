using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф14
{
    internal class Class1
    {

        private double _x;
        private double _l;

        public Class1(double x)
        {
            _x = x;
            
        }
        public void R()
        {
            Console.WriteLine($"R = {(Math.Pow(Math.Sin(Math.Pow(_x, 2) + 4), 3) + 4.33) / (Math.Pow(Math.Sin(Math.Pow(_x, 4)), 3))}");
        }
    }
}
