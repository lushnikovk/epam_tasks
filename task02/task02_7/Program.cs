using System;
//using task02_1;
//using task02_6;

namespace task02_7
{
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
     
        public double LengthSide (double x1, double y1, double x2, double y2) 
        {        
                return Math.Sqrt(((x2 - x1) * (x2 - x1) + ((y2 - y1) * (y2 - y1))));

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
         private double x1, y1, x2, y2, X1, Y1, X2, Y2;
        public DrawableRectangle(double x1, double y1, double x2, double y2, double X1, double Y1, double X2, double Y2) : base(x1, y1, x2, y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.X1 = X1;
            this.X2 = X2;
            this.Y1 = Y1;
            this.Y2 = Y2;
        }
        public void Draw()
        {
            Console.WriteLine("Длина стороны A= " + LengthSide(x1, y1, x2, y2));
            Console.WriteLine("Длина стороны B= " + LengthSide(X1, Y1, X2, Y2));
            Console.WriteLine("Периметр прямоугольника " + 2 * (LengthSide(x1, y1, x2, y2) + LengthSide(X1, Y1, X2, Y2)));
            Console.WriteLine("Площадь прямоугольника " + LengthSide(x1, y1, x2, y2) * LengthSide(X1, Y1, X2, Y2));

        }
    }



    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(" Выберите объект, который хотитет построить\n 1 - Линия \n 2 - Круг \n 3 -  Окружность \n 4 - Кольцо\n 5 - Прямоугольник\n Выход из программы ");
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
                        line.Draw();
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
                        round.Draw();
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
                        circle.Draw();
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
                        ring.Draw();
                        break;
                    case 5:
                        Console.WriteLine("Введите координаты стороны А");
                        Console.WriteLine("x1 = ");
                        if (!double.TryParse(Console.ReadLine(), out x1))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("y1 = ");
                        if (!double.TryParse(Console.ReadLine(), out y1))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("x2 = ");
                        if (!double.TryParse(Console.ReadLine(), out x2))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("y2 = ");
                        if (!double.TryParse(Console.ReadLine(), out y2))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");

                        }
                        Console.WriteLine("Введите координаты стороны B");
                        Console.WriteLine("x1 = ");
                        if (!double.TryParse(Console.ReadLine(), out double X1))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("y1 = ");
                        if (!double.TryParse(Console.ReadLine(), out double Y1))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("x2 = ");
                        if (!double.TryParse(Console.ReadLine(), out double X2))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");
                        }
                        Console.WriteLine("y2 = ");
                        if (!double.TryParse(Console.ReadLine(), out double Y2))
                        {
                            throw new ArgumentException("Данные введены неккоректно!");

                        }
                        DrawableRectangle rectangle = new DrawableRectangle(x1, y1, x2, y2, X1, Y1, X2, Y2);
                        rectangle.Draw();
                        break;
                    default:
                        Console.WriteLine("Данные введены неккоректно!");
                        break;
                    

                }




                Console.ReadKey();
            }

        }
    }
}

