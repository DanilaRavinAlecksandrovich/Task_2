using System;
using System.Collections.Generic;
using System.Text;

namespace Danila_2.Echo
{
    class Employee
    {
        public double sum1, sum2, sum, nalog;



        private double _dolhnosty;

        public double Dolhnosty
        {
            get { return _dolhnosty; }
            set { _dolhnosty = value; }
        }

        private double _stah;

        public double Stah
        {
            get { return _stah; }
            set { _stah = value; }
        }


        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Employee(string LastName, string Name)
        {
            this._lastName = LastName;
            this._name = Name;
        }

        public void OcladandNalog()
        {
            Console.WriteLine("Введите стаж работника (от 0 до 100 лет)");
            _stah = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите должность работника(от 1 до 10)");
            _dolhnosty = Convert.ToDouble(Console.ReadLine());

            if (_stah > 0 && _stah < 10) 
            {
                sum1 = 5000;
            }
            else if (_stah > 10 && _stah < 20)
            {
                sum1 = 10000;
            }
            else if (_stah > 20 && _stah < 30)
            {
                sum1 = 15000;
            }
            else if (_stah > 30 && _stah < 40)
            {
                sum1 = 20000;
            }
            else if (_stah > 40 && _stah < 50)
            {
                sum1 = 25000;
            }
            else if (_stah > 50 && _stah < 60)
            {
                sum1 = 30000;
            }
            else if (_stah > 60 && _stah < 70)
            {
                sum1 = 35000;
            }
            else if (_stah > 70 && _stah < 80)
            {
                sum1 = 40000;
            }
            else if (_stah > 80 && _stah < 90)
            {
                sum1 = 45000;
            }
            else if (_stah > 90 && _stah < 100)
            {
                sum1 = 50000;
            }

            if (_dolhnosty == 1)
            {
                sum2 = 10000;
            }
            else if (_dolhnosty == 2)
            {
                sum2 = 200000;
            }
            else if (_dolhnosty == 3)
            {
                sum2 = 300000;
            }
            else if (_dolhnosty == 4)
            {
                sum2 = 400000;
            }
            else if (_dolhnosty == 5)
            {
                sum2 = 500000;
            }
            else if (_dolhnosty == 6)
            {
                sum2 = 600000;
            }
            else if (_dolhnosty == 7)
            {
                sum2 = 700000;
            }
            else if (_dolhnosty == 8)
            {
                sum2 = 800000;
            }
            else if (_dolhnosty == 9)
            {
                sum2 = 900000;
            }
            else if (_dolhnosty == 10)
            {
                sum2 = 1000000;
            }

            sum = sum1 + sum2;

            if (sum >= 10000 && sum < 20000)
            {
                nalog = sum / 10;
            }
            else if (sum >= 20000 && sum < 30000)
            {
                nalog = sum / 15;
            }
            else if (sum >= 30000 && sum < 40000)
            {
                nalog = sum / 20;
            }
            else if (sum >= 40000 && sum < 50000)
            {
                nalog = sum / 25;
            }
            else if (sum >= 50000 && sum < 60000)
            {
                nalog = sum / 30;
            }
            else if (sum >= 60000 && sum < 70000)
            {
                nalog = sum / 35;
            }
            else if (sum >= 80000 && sum < 90000)
            {
                nalog = sum / 40;
            }
            else if (sum >= 100000)
            {
                nalog = sum / 45;
            }

            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Фамилия: {LastName}");
            Console.WriteLine($"Должность: {Dolhnosty}");
            Console.WriteLine($"Оклад: {sum}");
            Console.WriteLine($"Налог: {nalog}");
        }
    }
}
