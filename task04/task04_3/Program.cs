using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace task04_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = new[] { 5.5, -5.6, 18.9, 0, 5.6 };
            int[] a;
            Finish += Finish1;
            Input(out a);
            SortingInThread(a, (n, m) => n > m);
            SortingInThread(a, (n, m) => n > m);
            SortingInThread(a, (n, m) => n > m);
            SortingInThread(a, (n, m) => n > m);
            SortingInThread(a, (n, m) => n > m);
        }
        static void Finish1(string message)
        {
            Console.WriteLine(message);
        }
    


    public static void Sort<T>(T[] a, Func<T, T, bool> compare)
        {

            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (compare(a[j], a[j + 1]))
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
        static void Print <T>(T[] a)
        {

            foreach (var item in a)
            {
                Console.Write($"{item} ");
            }
        }

        public static event Action<string> Finish;

        public static void SortingInThread<T>(T[] a, Func<T, T, bool> compare)
        {
            Thread thread = new Thread(() =>
            {
                Console.WriteLine($"Starting  #{Thread.CurrentThread.ManagedThreadId}");
                Sort(a, compare);
                Print(a);
                Finish?.Invoke("Finish!" + Thread.CurrentThread.ManagedThreadId);    
            });
            thread.Start();
        }
       


    }
}
