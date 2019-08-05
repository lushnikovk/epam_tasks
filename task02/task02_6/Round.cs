using System;
using System.Collections.Generic;
using System.Text;

namespace task02_6
{
    public class Round
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

        private double radius;
        public Point Center { get; set; }
        public Round(Point Center, double Radius)
        {
            this.Center = Center;
            this.Radius = Radius;
        }


        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                    radius = value;
                else
                    throw new ArgumentException("Данные введены неккоректно! Радиус не может быть меньше или равен нулю.");
            }
        }
        public double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }
        public double CircleLength
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }
    }
}
