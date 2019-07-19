using System;
using System.Drawing;

namespace task02_1
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
    public class Round
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
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("введите координату x");
            //double x = double.Parse(Console.ReadLine());
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                throw new ArgumentException("Данные введены неккоректно!");
            }
            Console.WriteLine("введите координату y");
            if (!double.TryParse(Console.ReadLine(), out double y))
            {
                throw new ArgumentException("Данные введены неккоректно!");
            }
            Console.WriteLine("Введите радиус");
            if (!double.TryParse(Console.ReadLine(), out double radius))
            {
                throw new ArgumentException("Данные введены неккоректно!");
            }
            Round round = new Round(new Point(x,y), radius);
            Console.WriteLine($"Координаты центра круга: x = {round.Center.x}, y={round.Center.y}");
            Console.WriteLine("Длина Круга равна: " + round.CircleLength);
            Console.WriteLine("Площадь Круга равна: " + round.Area);

            Console.ReadKey();
        }
    }
}
