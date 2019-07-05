using System;
using System.Linq;

namespace task01_11
{
    class Program
    {
        public static double AverageStringLength(string str)
        {
            char[] mark = str.Where(Char.IsPunctuation).Distinct().ToArray();
            Array.Resize( ref mark, mark.Length + 1);
            mark[mark.Length - 1] = ' ';
            string[] words = str.Split(mark, StringSplitOptions.RemoveEmptyEntries);
            double summ = 0;
            for (int i = 0; i < words.Length; i++)
            {
                summ = summ + words[i].Length;
            }
            summ = summ/ words.Length;
            return summ;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine(AverageStringLength(str));
            Console.ReadKey();
        }
    }
}
