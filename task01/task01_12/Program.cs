using System;

namespace task01_12
{
    class Program
    {
        static bool Find(string str, char s)
        {
            char[] a = str.ToCharArray();
            bool res = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == s)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }
        static string CharDoubler(string firstString, string secondString)
        {
            var firstarray = firstString.ToCharArray();
            
            string resultstr = "";
            for (int i = 0; i < firstString.Length; i++)
            {
                resultstr = resultstr + (firstarray[i] + "");
                if (Find(secondString, firstarray[i]))
                {
                    resultstr = resultstr + (firstarray[i] + "");
                }
            }
        

            return resultstr;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку:" );
            var firstString = Console.ReadLine();

            Console.WriteLine("Введите вторую строку:");
            var secondString = Console.ReadLine();

            Console.WriteLine("Результат:" + CharDoubler(firstString, secondString));
            Console.ReadKey();
        }
    }
}
