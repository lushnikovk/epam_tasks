using System;
using System.Linq;

namespace task02_4
{
    class Program
    {
        class MyString
        {
            private char[] str;

            public MyString(string mystring)
            {

                str = mystring.ToCharArray();
            }

            public MyString(char[] mychar)
            {

                str = mychar;
            }
            public MyString()
            {

                str = new char[0];
            }
            public int Length
            {
                get
                {
                    return str.Length;
                }
            }

            public char this[int i]
            {
                get => str[i];
                set => str[i] = value;
            }
            public static bool operator >(MyString str1, MyString str2) => str1.str.Length > str2.str.Length;

            public static bool operator <(MyString str1, MyString str2) => str1.str.Length < str2.str.Length;

            public static bool operator ==(MyString str1, MyString str2)
            {
                if (str1.str.Length != str2.str.Length)
                {
                    return false;
                }

                for (int i = 0; i <= str1.str.Length - 1; i++)
                {
                    if (str1.str[i] != str1.str[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            public static bool operator !=(MyString str1, MyString str2)
            {
                if (str1.str.Length != str2.str.Length)
                {
                    return true;
                }

                for (int i = 0; i <= str1.str.Length - 1; i++)
                {
                    if (str1.str[i] != str1.str[i])
                    {
                        return true;
                    }
                }

                return false;
            }

            public static MyString operator +(MyString str1, MyString str2)
            {
                MyString newstring = new MyString();
                newstring.str = new char[str1.Length + str2.Length];
                str1.str.CopyTo(newstring.str, 0);
                str2.str.CopyTo(newstring.str, str1.Length);
                return newstring;
            }
            public char[] ToCharArray()
            {
                return str;
            }
            public override string ToString()
            {
                return new string(str);
            }

            public MyString Sort()
            {
                char sort;

                for (int i = 0; i < str.Length - 1; i++)
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[j] < str[i])
                        {
                            sort = str[i];
                            str[i] = str[j];
                            str[j] = sort;
                        }
                    }
                }
                return this;
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Создадим объект через массив");
            var myString1 = new MyString(new char[] { 'a', 'b', 'c', 'd' });
            Console.WriteLine("MyString1: " + myString1);
            Console.WriteLine("Создадим объект через строку, введите её");
            var myString2 =  new MyString(Console.ReadLine());
            Console.WriteLine("MyString2: " + myString2);
            Console.WriteLine(" 1 - конкатенация \n  2 - Сортировка \n 3 -  поиск символа \n 4 - сравнение строк \n  5 - длина массива ");
            while (true)
            {
                Console.WriteLine("выберете действие");
                Console.WriteLine("введите число ");
                int n = int.Parse(Console.ReadLine());
               
                switch (n)
                {
                    case 1:
                        var myString3 = myString1 + myString2;
                        Console.WriteLine("MyString1 + MyString2: " + myString3);
                        break;
                    case 2:
                        myString3 = myString1 + myString2;
                        myString3.Sort();
                        Console.WriteLine("Сортировка MyString3: " + myString3);
                        break;
                    case 3:
                        myString3 = myString1 + myString2;
                        Console.WriteLine("MyString3[0] = " +  myString3[0]);
                        break;
                    case 4:
                        Console.WriteLine("Первая строка больше чем вторая: {0}", myString1 > myString2);
                        Console.WriteLine("Вторая строка больше чем первая: {0}", myString1 < myString2);
                        break;
                    case 5:
                        myString3 = myString1 + myString2;
                        Console.WriteLine("Длина MyString3:");
                        Console.WriteLine(myString3.Length);
                        break;
                }

            }
                Console.ReadKey();
            

        }
    }

}