using System;

namespace task01_7
{
    class Program
    {
        static void Input(out int[] a, out int r)
        {

            Console.Write("введите размерность r= ");
            r = int.Parse(Console.ReadLine());
            a = new int[r];
            if (r > 0)
            {
                Random rnd = new Random();
                for (int i = 0; i < r; i++)
                {
                    a[i] = rnd.Next(-100, 100);

                }
            }
            else
            {
                Console.WriteLine("данные введены некорректно!");
            }
           
        }
        static void Sort(int[] a)//метод пузырька
        {
            int t;
            for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = a.Length - 1; j > i; j--)
                        {
                            if (a[j] < a[j - 1])
                                {
                                    t = a[j];
                                    a[j] = a[j - 1];
                                    a[j - 1] = t;
                                }
                        }
                }
        }
        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                {
                    Console.Write("{0} ", a[i]);
                }
            }
            Console.WriteLine();
        }
        public static int Max(int[] a)
        {
            int res = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (res < a[i])
                {
                    res = a[i];
                }
            }
            return res;
        }
        public static int Min(int max,int[] a)
        {
            int res = max;
            for (int i = 0; i < a.Length; ++i)
            {
                if (res > a[i])
                {
                    res = a[i];
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            int[] a;
            int r;
            try
            {
                Input(out a, out r);
                Console.WriteLine("Исходный массив:");
                Print(a);
                Sort(a);
                Console.WriteLine("отсортированный массив по возрастанию: ");
                Print(a);
                Console.WriteLine("максимальный элемент: ");
                Console.WriteLine(Max(a));
                Console.WriteLine("Минимальный элемент:  ");
                Console.WriteLine(Min(Max(a), a));
            }
           catch
            {
                Console.WriteLine("Данные введены некорректно!");
            }
            Console.ReadKey();
        }
    }
}
