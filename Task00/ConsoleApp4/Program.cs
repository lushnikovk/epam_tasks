using System;

namespace ConsoleApp3
{
     class Program
    {
        //Первое задание
        static void Line(int N)
        { 
            if (N < 0)
                Console.WriteLine("Данные введены неккоректно!");
            for (int i = 1; i <= N; i++)
            {
                if (i != N)
                    Console.Write("{0},", Convert.ToString(i));
                else
                    Console.Write("{0}.", Convert.ToString(i));
            }
            Console.WriteLine();
        }
        //Второе задание
        static void Simple(int N)
        {
            if (N < 0)
            {
                Console.WriteLine("Данные введены неккоректно!");
                    }
            else
            {
                bool check = true;
                for (int i = 2; i <= N / 2; i++)
                {
                    if (N % i == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    Console.WriteLine("Заданное число является простым");
                else
                    Console.WriteLine("Заданное число не является простым");

                Console.WriteLine();
            }
        }
        //Третье задание
        static void Square(int N)
        {
            if ((N < 0) || (N % 2 == 0))
            {
                Console.WriteLine("Данные введены неккоректно!");
            }
            else
            {
            int k = 1, m;
            while (k <= N)
            {
                m = 1;
                while (m <= N)
                {

                    Console.Write("*");
                    m++;
                    if (((N + 1) / 2 == k) && ((N + 1) / 2 == m))
                    {
                        Console.Write(" ");
                        m++;
                    }
                }
                Console.WriteLine();
                k++;
            }
            Console.WriteLine();
        }
    }
        static void Main(string[] args)
        {
//Первое задание
         int n;
         Console.WriteLine("Введите число");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                Line(n);
            }
            catch (FormatException)
            {
                Console.WriteLine("Данные введены неккоректно!");
            }
            
//Второе задание
            Console.WriteLine("Введите число");
            try
            {
                n = int.Parse(Console.ReadLine());
                Simple(n);
            }
            catch (FormatException)
            {
                Console.WriteLine("Данные введены неккоректно!");
            }
//Третье задание
            Console.WriteLine("Введите число");
            try
            {
                n = int.Parse(Console.ReadLine());
                Square(n);
            }
            catch
            {
                Console.WriteLine("Данные введены неккоректно!");
            }
            Console.ReadKey();
        }
    }
}
