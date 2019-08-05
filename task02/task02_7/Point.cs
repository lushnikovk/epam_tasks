using System;
using System.Collections.Generic;
using System.Text;

namespace task02_7
{
    public struct Point
    {
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double x { get; set; }
        public double y { get; set; }
    }
}
