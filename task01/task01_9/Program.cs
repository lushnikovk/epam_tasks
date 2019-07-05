using System;

namespace task01_7
{
    class Program
    {
        static void Input(out int[,,] a)
        {
            int r = 3;
            a = new int[10, 10, 10];

            Random rnd = new Random();
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    for (int k = 0; k < r; k++)
                    {
                        a[i, j, k] = rnd.Next(-100, 100);
                    }
                }

            }
        }

        static void Print(int[,,] a)
        {
            int r = 3;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    for (int k = 0; k < r; k++)
                    {
                        Console.Write("{0} ", a[i, j, k]);
                    }
                }
            }
            Console.WriteLine();
        }
        static int Summ(int[,,] a)
        {
            int sum = 0;
            int r = 3;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    for (int k = 0; k < r; k++)
                    {
                        if (a[i, j, k] > 0)
                            sum = sum + a[i, j, k];
                    }
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[,,] a;

            try
            {
                Input(out a);
                Print(a);
               Console.WriteLine("Сумма неотрицательных элементов массива равна " + Summ(a));
               
            }
            catch
            {
                Console.WriteLine("Данные введены некорректно!");
            }
            Console.ReadKey();
        }
    }
}
