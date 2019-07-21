using System;

namespace task01_2_3_4
{
    class Program
    {
        public static void Triangle(int n)
        {
                for (int i = 0; i <= n; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
        }
        public static void AnotherTriangle(int n)
        {

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < n + i; j++)
                {
                    if (j <= n - i)
                        Console.Write(' ');
                    else
                        Console.Write('*');
                }

                Console.WriteLine();
            }
        }
        
       
        public static void XmasTree(int n)
        {

            for (int x = 0; x <= n; x++)
            {
                for (int i = 0; i <= x; i++)
                {
                    for (int j = 0; j <n+i; j++)
                    {
                        if (j <= n - i)
                            Console.Write(' ');
                        else
                            Console.Write('*');
                    }
                    Console.WriteLine();
                }
                
            }
        }
        static void Main(string[] args)
        {
            while (true)
            { 
                try
                {
                    Console.WriteLine("Введите число: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("1- triangle, 2 - another triangle, 3 - X-MAS TREE. Введите цифру: " );
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (n > 0)
                    {
                        switch (number)
                        {
                            case 1:
                                Triangle(n);
                                break;
                            case 2:
                                AnotherTriangle(n);
                                break;
                            case 3:
                                XmasTree(n);
                                break;
                        }

                    }
                        
                    else Console.WriteLine("данные введены неккоректно");
                }
                catch
                {
                    Console.WriteLine("данные введены неккоректно");
                }
        }
        }
    }
}

