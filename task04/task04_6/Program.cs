using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04_6
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void Print<T>(T[] a)
        {

            foreach (var item in a)
            {
                Console.Write($"{item} ");
            }
        }

        private static bool GetPositive(int i) => i > 0;
        private static int[] FindCasual(int[] arr)
        {
            List<int> List = new List<int>();

            foreach (var item in arr)
            {
                if (item > 0)
                {
                    List.Add(item);
                }
            }

            return List.ToArray();
        }
        private static T[] FindthroughDelegate<T>(T[] arr, Predicate<T> find)
        {
            List<T> List = new List<T>();

            foreach (var item in arr)
            {
                if (find.Invoke(item))
                {
                    List.Add(item);
                }
            }

            return List.ToArray();
        }
        private static int[] FindLinq(int[] NewArr)
        {
            NewArr = (from item in NewArr where item > 0 select item).ToArray();
            return NewArr;
        }

    }
}
