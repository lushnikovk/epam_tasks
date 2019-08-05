using System;



namespace task02_6
{

    public class Ring: Round
    {
       // public Point Center { get; set; }
        private double innerRadius;
        public Ring (double x,double y,double Radius,double InnerRadius) :base(new Point(x,y),Radius)

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
                if (value < Radius&& value > 0)
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
              return  Math.PI* (Radius *Radius - innerRadius * innerRadius);
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
            Console.WriteLine("Введите внутренний радиус");
            if (!double.TryParse(Console.ReadLine(), out double innerRadius))
            {
                throw new ArgumentException("Данные введены неккоректно!");
            }
            Console.WriteLine("Введите внешний радиус");
            if (!double.TryParse(Console.ReadLine(), out double outRadius))
            {
                throw new ArgumentException("Данные введены неккоректно!");
            }
            Ring ring = new Ring(x, y, outRadius, innerRadius);
            Console.WriteLine($"Координаты центра Кольца: x = {ring.Center.x}, y={ring.Center.y}");
            Console.WriteLine("Суммарная длина внешней и внутренней окружностей равна: " + ring.SumLength);
            Console.WriteLine("Площадь кольца равна: " + ring.RingArea);
            Console.ReadKey();
        }
    }
}
