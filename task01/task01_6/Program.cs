using System;

namespace task01_6
{
    class Program
    {
        [Flags]
        public enum ParamFont
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4,
        }
        static void Main(string[] args)
        {
            ParamFont Font = ParamFont.None;
            int number;
            while (true)
            {
                Console.WriteLine("Параметры надписи: " + Font);
                Console.WriteLine("Введите:");
                for (int i = 1; i <= 3; i++)
                {
                    ParamFont s = (ParamFont)(int)Math.Pow(2, i - 1);
                    Console.WriteLine("\t{0}: {1}", i, s);
                }
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    switch (number)
                    {
                        case 1:
                            Font ^= ParamFont.Bold;
                            break;
                        case 2:
                            Font ^= ParamFont.Italic;
                            break;
                        case 3:
                            Font ^= ParamFont.Underline;
                            break;
                        default:
                            Console.WriteLine("Данные введены некорректно!");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Данные введены некорректно!");
                }

               
            } 
        }
    }
}