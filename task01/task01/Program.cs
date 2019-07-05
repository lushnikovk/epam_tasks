using System;

namespace task01_1
{
    class Program

    {

        static void Input(char name, out int value) // name - название стороны, value - размер.
        {
            while (true)
            {
                Console.Write($"Введите сторону {name}: ");
               bool a = int.TryParse(Console.ReadLine(), out  value);
               
                if (a && value > 0)
                    break;
                else
                    Console.WriteLine("Данные введены неккоректно!");
            }
            Console.WriteLine();
        }
       
        static void Main(string[] args)
        {

                Input('a',out int a);
                Input('b',out int b);
                Console.WriteLine($"Площадь прямоугольника равна: " + a * b);
;
            Console.ReadKey();
        }
    }

}
