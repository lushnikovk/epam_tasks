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
            var a = new[] { "b","bb","a","beagle","cin","can","cout" };
           // Input(out a);
            Console.WriteLine("Массив до сортировки");
            Print(a);
            Console.WriteLine();
            Sort(a, Compare);
            Console.WriteLine("Массив после сортировки");
            Print(a);
            Console.ReadKey();
        }
        public static void Sort<T>(T[] array, Func<T, T, bool> comparer)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (comparer(array[j], array[j + 1]))
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }


        }
        static bool Compare(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return true;
            }

            if (str1.Length == str2.Length)
            {
                if (str1[0] < str2[0]) return false;

                for (int i = 1; i < str1.Length; i++)
                {
                    if (str1[i] > str2[i])
                    {
                        return true;
                    }
                }
            }
            if (str1.Length == 1 && str2.Length == 1)
                return true;

            return false;
        }
        static void Print(string[] a)
        {

            foreach (var item in a)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
