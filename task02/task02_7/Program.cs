using System;
using task02_1;
using task02_6;

namespace task02_7
{
    public interface IDrawable
    {
        void Draw();
    }

    class Line
    {

        public Point First { get; set; }
        public Point Second { get; set; }
        private double X1, X2, Y1, Y2;
        public Line(double x1, double y1, double x2, double y2)
        {
            First = new Point(x1, y1);
            Second = new Point(x2, y2);

        }

        public double LengthLine
        {
            get
            {
                return Math.Sqrt(((Second.x - First.x) * (Second.x - First.x) + ((Second.y - First.y) * (Second.y - First.y))));
            }

        }
    }
    /// <summary>
    /// Строим прямоугольник по двум точкам
    /// </summary>
    class Rectangle : Line
    {

        public Rectangle(double x1, double y1, double x2, double y2) : base(x1, y1, x2, y2)
        {

        }

        public double A
        {
            get
            {
                return LengthLine;
            }
        }
        public double B
        {
            get
            {
                return LengthLine;
            }
        }

    }
    class Circle : Round
    {
        public Circle(double x, double y, double Radius) : base(new Point(x, y), Radius)
        {

        }
    }
    class DrawableRing : Ring, IDrawable
    {

        public DrawableRing(double x1, double y1, double Radius, double innerRadius) : base(x1, y1, Radius, innerRadius)
        {

        }
        public void Draw()
        {
            Console.WriteLine($"Координаты центра Кольца: x = {Center.x}, y={Center.y}");
            Console.WriteLine("Суммарная длина внешней и внутренней окружностей равна: " + SumLength);
            Console.WriteLine("Площадь кольца равна: " + RingArea);
        }
    }
    class DrawableRound : Round, IDrawable
    {
        public DrawableRound(double x, double y, double Radius) : base(new Point(x, y), Radius)
        {

        }
        public void Draw()
        {
            Console.WriteLine($"Координаты центра круга: x = {Center.x}, y={Center.y}");
            Console.WriteLine("Длина Круга равна: " + CircleLength);
            Console.WriteLine("Площадь Круга равна: " + Area);
        }
    }

    class DrawableCircle : Circle, IDrawable
    {
        public DrawableCircle(double x, double y, double Radius) : base(x, y, Radius)
        {

        }
        public void Draw()
        {
            Console.WriteLine($"Координаты центра окружности: x = {Center.x}, y={Center.y}");
            Console.WriteLine("Длина окружности равна: " + CircleLength);

        }
    }
    class DrawableLine : Line, IDrawable
    {
        public DrawableLine(double x1, double y1, double x2, double y2) : base(x1, y1, x2, y2)
        {

        }
        public void Draw()
        {
            Console.WriteLine("Координаты центра начала линии:{0}, {1}", First.x, First.y);
            Console.WriteLine("Координаты центра конца линии:{0}, {1}", Second.x, Second.y);
            Console.WriteLine("Длина линии равна: " + LengthLine);

        }
    }
    class DrawableRectangle : Rectangle, IDrawable
    {
        public DrawableRectangle(double x1, double y1, double x2, double y2) : base(x1, y1, x2, y2)
        {

        }
        public void Draw()
        {
            Console.WriteLine("Длина стороны A= " + A);
            Console.WriteLine("Длина стороны B= " + B);
            Console.WriteLine("Периметр прямоугольника " + 2 * (A + B));
            Console.WriteLine("Площадь прямоугольника " + A * B);

        }
    }
    


    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(" Выберите объект, который хотитет построить\n 1 - Линия \n 2 - Круг \n 3 -  Окружность \n 4 - Кольцо\n 5 - Прямоугольник ");
            while (true)
            {

                Console.WriteLine("введите число ");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("введите первую координату");
                        Console.WriteLine("x = ");
                        if (!double.TryParse(Console.ReadLine(), out double x1))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("y = ");
                        if (!double.TryParse(Console.ReadLine(), out double y1))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("введите вторую координату");
                        Console.WriteLine("x = ");
                        if (!double.TryParse(Console.ReadLine(), out double x2))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("y = ");
                        if (!double.TryParse(Console.ReadLine(), out double y2))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        DrawableLine line = new DrawableLine(x1, y1, x2, y2);
                        break;
                    case 2:
                        Console.WriteLine("введите координату центра ");
                        Console.WriteLine("x = ");
                        if (!double.TryParse(Console.ReadLine(), out x1))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("y = ");
                        if (!double.TryParse(Console.ReadLine(), out y1))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("введите радиус ");
                        if (!double.TryParse(Console.ReadLine(), out double r))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        DrawableRound round = new DrawableRound(x1, y1, r);
                        break;
                    case 3:
                        Console.WriteLine("введите координату центра ");
                        Console.WriteLine("x = ");
                        if (!double.TryParse(Console.ReadLine(), out x1))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("y = ");
                        if (!double.TryParse(Console.ReadLine(), out y1))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("введите радиус ");
                        if (!double.TryParse(Console.ReadLine(), out r))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        DrawableRound circle = new DrawableRound(x1, y1, r);
                        break;
                    case 4:
                        Console.WriteLine("введите координату центра ");
                        Console.WriteLine("x = ");
                        if (!double.TryParse(Console.ReadLine(), out x1))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("y = ");
                        if (!double.TryParse(Console.ReadLine(), out y1))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("введите внешний радиус ");
                        if (!double.TryParse(Console.ReadLine(), out double r1))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("введите внутренний радиус ");
                        if (!double.TryParse(Console.ReadLine(), out double r2))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        DrawableRing ring = new DrawableRing(x1, y1, r1, r2);
                        break;
                    case 5:
                        //DrawableRectangle rectangle = new DrawableRectangle(5, 6, 2, 2);
                        break;

                }

                Console.ReadKey();
            }
        }
    }
}

