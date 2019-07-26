using System;
using System.Collections.Generic;
namespace task03_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"last human:  {GetLastHuman()}");

            Console.ReadKey();
        }
        static List<int> GetCircleOfPeople()
        {
            Console.WriteLine("Enter the number of people in the circle: ");
            int.TryParse(Console.ReadLine(), out int NumberOfPeople); ;

            List<int> list = new List<int>();

            for (int i = 0; i < NumberOfPeople; i++)
            {
                list.Add(i + 1);
            }

            return list;
        }
        static int GetLastHuman()
        {
            List<int> list = GetCircleOfPeople();

            int cur = 0;
            int count = 0;

            while (list.Count != 1)
            {
                if (count == 1)
                {
                    Console.WriteLine("Удалён участник под номером {0}", list[cur]);
                    list.RemoveAt(cur);
                    count = 1;
                    cur--;
                }
                else count++;

                if (cur == list.Count - 1)
                    cur = 0;
                else cur++;

            }

            return list[0];
        }

    }

}

