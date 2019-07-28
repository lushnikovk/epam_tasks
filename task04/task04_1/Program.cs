using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            Input(out a);
            Console.WriteLine("Массив до сортировки");
            Print(a);
            Console.WriteLine();
            Sort(a, (n, m) => n> m);
            Console.WriteLine("Массив после сортировки");
            Print(a);
            Console.ReadKey();
        }
        public static void Sort<T>(T[] a, Func<T, T, bool> compare)
        {

            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = 0; j < a.Length-1; j++)
                {
                    if (compare(a[j], a[j+1]))
                    {
                        T temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            
        }
        static void Input(out int[] a)
        {
            int r = 10;
            a = new int[r];

            Random rnd = new Random();
            for (int i = 0; i < r; i++)
            {
                {
                    a[i] = rnd.Next(0, 10);
                }

            }
        }
        static void Print(int[] a)
        {

            foreach (var item in a)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
