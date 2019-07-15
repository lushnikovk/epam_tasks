using System;
using System.Linq;

namespace task02_3
{
    class Program
    {
        class User
        {
            private string Firstname,Lastname,Patronymic;

            public User(string firstname, string lastname, string patronymic, DateTime birthday)
            {
                this.firstname = firstname;
                this.lastname = lastname;
                this.patronymic = patronymic;
                this.birthday = birthday;
            }
            public string firstname
            {
                get
                {
                    return Firstname;
                }
                set
                {
                    if (value != "")
                        Firstname = value;
                    else
                        throw new ArgumentException("Данные введены неккоректно!");
                }
            }
            public string lastname
            {
                get
                {
                    return Lastname;
                }
                set
                {
                    if (value != "")
                        Lastname = value;
                    else
                        throw new ArgumentException("Данные введены неккоректно!");
                }
            }
            public string patronymic
            {
                get
                {
                    return Patronymic;
                }
                set
                {
                    if (value != "")
                        Patronymic = value;
                    else
                        throw new ArgumentException("Данные введены неккоректно!");
                }
            }
            public DateTime birthday { get; set; }
            public int age
            {
                get
                {
                    return DateTime.Now.Year - birthday.Year;
                }
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("введите имя");
            string firstname = Console.ReadLine();

            Console.WriteLine("введите фамилию");
            string lastname = Console.ReadLine();

            Console.WriteLine("Введите Отчество");
            string patronymic = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime birthdate))
            {
                throw new ArgumentException("Данные введены неккоректно!");
            }
            User user = new User(firstname, lastname, patronymic, birthdate);
            Console.WriteLine("{0}, {1}, {2}, {3}, Дата рождения  {4}",  user.firstname, user.lastname,user.patronymic,user.age, user.birthday);
            Console.ReadKey();
        }
    }
}
