using System;
using System.Collections.Generic;
using System.Text;

namespace task02_5
{
    public class User
    {
        private string Firstname, Lastname, Patronymic;

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
}
