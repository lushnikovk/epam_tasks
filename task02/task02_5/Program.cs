using System;


namespace task02_5
{
    class Employee : User
    {
        private int expirience;
        public int Expirience
        {
            get
            {
                return expirience;
            }
            set
            {
                if (value > 0)
                    expirience = value;
                else if (value == 0)
                {
                    Console.WriteLine("Опыт работы отсутствует");
                    
                }
                else
                    throw new ArgumentException("Данные введены неккоректно!");
            }
        }
        public string Post { get; set; }

        public Employee(string Post, int Expirience, string firstname, string lastname, string patronymic, DateTime birthday) : base(firstname, lastname, patronymic, birthday)
        {
            this.Expirience = Expirience;
            this.Post = Post;
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
            Console.WriteLine("Введите опыт работы");
            if (!int.TryParse(Console.ReadLine(), out int exp))
            {
                throw new ArgumentException("Данные введены неккоректно!");
            }
            Console.WriteLine("Введите должность");
            string post = Console.ReadLine();

            Employee emp = new Employee(post, exp, firstname, lastname, patronymic, birthdate);
            Console.WriteLine("{0}, {1}, {2}, {3}, Дата рождения  {4}, Опыт работы {5}, должность {6}", emp.firstname, emp.lastname, emp.patronymic, emp.age, emp.birthday, emp.Expirience, emp.Post);
            Console.ReadKey();
        }


    }
}
