using System;
using System.Collections.Generic;
using System.Text;

namespace task04_4_and_5
{ 
    public static class Program
    {

        static void Main(string[] args)
        {


        }
        public static T GetSumm<T>(Func<T, T, T> summFunc, T[] arr)
        {
            T sum = default;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = summFunc(sum, arr[i]);
            }

            return sum;
        }
        public static bool IsInThisStringNumberPositive(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    return false;
                }
            }

            if (str.StartsWith("-"))
            {
                return false;
            }
            return true;
        }
    }
}
