using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace task05
{
    class Program
    {
        static void Main()
        {
            SelectOptionByUser();
        }

         static object SelectOptionByUser()
        {
                string select;
                Console.WriteLine("Plase select some action:");
                Console.WriteLine("1. backup");
                Console.WriteLine("2. Watch");
                Console.WriteLine("3. Exit");
                var input = Console.ReadLine();

                if (uint.TryParse(input, out uint selectedOption)
                    && selectedOption > 0
                    && selectedOption < 4)
                {

                    switch (selectedOption)
                    {
                        case 1:
                            Console.Write("Введите дату и время в соответствии с шаблоном" + "  yyyy.MM.dd-HH.mm.ss   ");
                            select = Console.ReadLine();

                            if (DateTime.TryParseExact(select, "yyyy.MM.dd-HH.mm.ss", null, DateTimeStyles.None, out DateTime date))
                                return date;
                            Backup backup = new Backup();
                            backup.datetime = date;
                            backup.Recoil();
                            return "осуществлён откат данных";
                        case 2:
                            return new Watcher();
                        case 3:
                            return 0;
                    }
                }
            return 0;
        }
    }
}

