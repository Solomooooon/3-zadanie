﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фиф12
{
    internal class Class1
    {

        private double _x;
        private double _y;
        private double _a;

        public Class1(double x, double y, double a)
        {
            _x = x;
            _y = y;
            _a = a;
        }
        public void G()
        {
            Console.WriteLine($"G = {(Math.Pow(Math.Cos(Math.Abs(_y + _x)), 3) - (_x + _y)) / Math.Pow(Math.Atan(_x + _a), 4) * Math.Pow(_x, 5)}");
        }
    }
}
