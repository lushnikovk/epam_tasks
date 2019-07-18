using System;


namespace task02_2
{
   
        class Triangle
        {
            private double A, B, C;
            public Triangle(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public double a
            {
                get
                {
                    return A;
                }
                set
                {
                    if (value >= 0)
                        A = value;
                    else
                        throw new ArgumentException("Данные введены неккоректно!");
                }
            }
            public double b
            {
                get
                {
                    return B;
                }
                set
                {
                    if (value >= 0)
                        B = value;
                    else
                        throw new ArgumentException("Данные введены неккоректно!");
                }
            }
            public double c
            {
                get
                {
                    return C;
                }
                set
                {
                    if (value >= 0)
                        C = value;
                    else
                        throw new ArgumentException("Данные введены неккоректно!");
                }
            }
            public double Perimetr
            {
                get
                {
                    return a + b + c;
                }
            }
            public double Area
            {
                get
                {
                    double SemiPerimetr = Perimetr * 0.5;
                    return Math.Sqrt(SemiPerimetr * (SemiPerimetr - a) * (SemiPerimetr - b) * (SemiPerimetr - c));
                }
            }
        }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("введите сторону a");
            //double x = double.Parse(Console.ReadLine());
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                throw new ArgumentException("Данные введены неккоректно!");
            }
            Console.WriteLine("введите сторону b");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                throw new ArgumentException("Данные введены неккоректно!");
            }
            Console.WriteLine("Введите сторону с ");
            if (!double.TryParse(Console.ReadLine(), out double c))
            {
                throw new ArgumentException("Данные введены неккоректно!");
            }
            Triangle triangle = new Triangle(a, b, c);
            if (a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine("Периметр равен: " + triangle.Perimetr);
                Console.WriteLine("Площадь равна: " + triangle.Area);
            }
            else
            {
                throw new ArgumentException("Данные введены неккоректно!");
            }
               

            Console.ReadKey();
        }
    }
}
