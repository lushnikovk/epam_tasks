using System;


namespace task02_1
{
    class Program
    {


        class Round
        {
           private double radius;
            public  Round(double x, double y, double Radius)
            {
                this.x = x;
                this.y = y;
                this.Radius = Radius;
            }
           public double x { get; set; }
           public double y { get; set; }

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
            public double Area()
            {
                return Math.PI * Radius * Radius;
            }
            public double CircleLength()
            {
                return 2 * Math.PI * Radius;
            }
        }
        static void Main(string[] args)
        {
           
              
                Console.WriteLine("введите координату x");
                //double x = double.Parse(Console.ReadLine());
                if (!double.TryParse(Console.ReadLine(),out double x))
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
                Round round = new Round(x, y, radius);
                Console.WriteLine($"Координаты центра окружности: x = {round.x}, y={round.y}");
                Console.WriteLine("Длина окружности равна: " + round.CircleLength());
                Console.WriteLine("Длина окружности равна: " + round.Area());




            Console.ReadKey();
        }
    }
}
