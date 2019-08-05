using System;
using System.Collections.Generic;
using System.Text;

namespace task02_7
{
    class Round
    {
    
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
}
