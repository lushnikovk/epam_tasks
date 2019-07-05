using System;

namespace task01_5
{
    class Program
    {
        private static int Summa()
        {
            int summa = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    summa = summa + i;
                }
            }

            return summa;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Сумма целых чисел от 1 до 1000, делимая на 3 и 5 без остатка равна : " + Summa());
            Console.ReadKey();
        }
    }
}
