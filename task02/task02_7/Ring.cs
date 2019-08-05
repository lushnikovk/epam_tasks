using System;
using System.Collections.Generic;
using System.Text;

namespace task02_7
{

    public class Ring : Round
    {
        // public Point Center { get; set; }
        private double innerRadius;
        public Ring(double x, double y, double Radius, double InnerRadius) : base(new Point(x, y), Radius)

        {
            this.Center = Center;
            this.InnerRadius = InnerRadius;
        }
        public double InnerRadius
        {
            get
            {
                return innerRadius;
            }
            set
            {
                if (value < Radius && value > 0)
                    innerRadius = value;
                else
                    throw new ArgumentException("Данные введены неккоректно! Внутренний радиус не может быть меньше или равен нулю, а так же больше внутреннего радиуса");
            }
        }
        //public Point x { get; set; }
        //public Point y { get; set; }
        public double InnerLength
        {
            get => 2 * Math.PI * innerRadius;
        }
        public double OutLength
        {
            get => 2 * Math.PI * Radius;
        }
        public double SumLength
        {
            get
            {
                return InnerLength + OutLength;
            }
        }
        public double RingArea
        {
            get
            {
                return Math.PI * (Radius * Radius - innerRadius * innerRadius);
            }
        }

    }
}
