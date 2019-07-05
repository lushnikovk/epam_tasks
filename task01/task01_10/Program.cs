using System;

namespace task01_7
{
    class Program
    {
        static void Input(out int[,] a)
        {
            
            a = new int[5, 5];

            Random rnd = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    
                        a[i, j] = rnd.Next(-100, 100);
                    
                }

            }
        }

        static void Print(int[,] a)
        {
            
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                     Console.Write("{0,3} ", a[i, j]);   
                }
                Console.WriteLine();
            }
            
        }
        static int Summ(int[,] a)
        {
            int sum = 0;
            int s = 0;//сумма номеров его позиций
           
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    s = i + j;
                        if (s % 2 == 0)
                            sum = sum + a[i, j];
                  s = 0;
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[,] a;

            try
            {
                Input(out a);
                Print(a);
                Console.WriteLine("Сумма элементов стоящих на чётных позициях " + Summ(a));

            }
            catch
            {
                Console.WriteLine("Данные введены некорректно!");
            }
            Console.ReadKey();
        }
    }
}
