using System;
using System.Collections.Generic;
using System.Text;

namespace Danila_2.Echo
{
    class User
    {
        private string _login;
        public string Login//В свойстве реализованна проверка на переполнение.
        {
            get { return _login; }
            set { _login = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _age;
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        readonly DateTime date;


        public User(string login, string name, string lastName, string age)
        {
            this.Login = login;
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            date = DateTime.Now;
        }

        
        public void Show()
        {
            Console.WriteLine($"Логин: {Login}");
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Фамилия: {LastName}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Дата создания анкеты: {date}");
        }
    }
}
