using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф3
{
    internal class Clasee
    {
        private double _y;
        private double _h;

        public Clasee(double y, double h)
        {
            _y = y;
            _h = h;
        }
        public void A()
        {
            Console.WriteLine($"A = {(Math.Tan(Math.Pow(_y, 3) - Math.Pow(_h, 4)) + Math.Pow(_h, 2)) / (Math.Pow(Math.Sin(_h), 2) + _y)}");
        }
    }
}
