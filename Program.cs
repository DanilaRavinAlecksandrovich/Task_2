using System;
using Danila_2.Echo;

namespace Danila_2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user_1 = new User("31012004", "Равин", "Данила", "18");
            user_1.Show();
            Console.Write($"\n");

            int repeat = 5;
            for (int i = 0; i < repeat; i--)
            {
                Converter money = new Converter(25, 20, 15);
                Console.WriteLine("Введите число рублей:");
                money.RUB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберите курс валюты: ");
                Console.WriteLine($"BTC (Цифра 1): {money.BTC}, \nETH (Цифра 2): {money.ETH}, \nBHB (Цифра 3): {money.BHB}, \nВведёное число рублей: {money.RUB}, \nВыйти (Цифра 4), \nПродолжить (Цифра 5)");
                Console.WriteLine("Перевод: ");
                int kurs;
                kurs = Convert.ToInt32(Console.ReadLine());
                if (kurs == 1)
                {
                    double convert = money.RUB / money.BTC;
                    Console.WriteLine($"BTC:  {convert}");
                    Console.WriteLine(" ");
                }
                else if (kurs == 2)
                {
                    double convert = money.RUB / money.BTC;
                    Console.WriteLine($"ETH:  {convert}");
                    Console.WriteLine(" ");
                }
                else if (kurs == 3)
                {
                    double convert = money.RUB / money.BTC;
                    Console.WriteLine($"BHB:  {convert}");
                    Console.WriteLine(" ");
                }
                else if (kurs == 4)
                {
                    int KeyWord = 4;
                    if (kurs == KeyWord)
                        Environment.Exit(0);
                    Console.WriteLine($"");
                }
                else if (kurs == 5)
                {
                    break;
                    Console.WriteLine($"");
                }
            }

            Console.WriteLine(" ");

            int repeat1 = 10;
            for (int j = 0; j < repeat1; j--)
            {
                Converter money = new Converter(25, 20, 15);
                Console.WriteLine("Введите число валюты:");
                money.RUB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Перевести из другой валюты или выйти: ");
                Console.WriteLine("Выберите валюту или нажминте \"выйти\" ");
                Console.WriteLine($"BTC (Цифра 1): {money.BTC}, \nETH (Цифра 2): {money.ETH}, \nBHB (Цифра 3): {money.BHB}, \nВыйти (Цифра 4), \nЗавершить (Цифра 5)");
                Console.WriteLine("Выберите курс валют: ");
                int kurs2;
                kurs2 = Convert.ToInt32(Console.ReadLine());
                if (kurs2 == 1)
                {
                    double convert = money.RUB * money.BTC;
                    Console.WriteLine($"BTC:  {convert}");
                    Console.WriteLine(" ");

                }
                else if (kurs2 == 2)
                {
                    double convert = money.RUB * money.ETH;
                    Console.WriteLine($"ETH: {convert}");
                    Console.WriteLine(" ");
                }
                else if (kurs2 == 3)
                {
                    double convert = money.RUB * money.BHB;
                    Console.WriteLine($"BHB:  {convert}");
                    Console.WriteLine(" ");
                }
                else if (kurs2 == 4)
                {
                    int KeyWord = 4;
                    if (kurs2 == KeyWord)
                        Environment.Exit(0);
                    Console.WriteLine($"");
                }
                else if (kurs2 == 5)
                {
                    break;
                    Console.WriteLine($"");
                }
            }
            Console.WriteLine(" ");

            Employee Employee = new Employee("Равин", "Данила");
            Employee.OcladandNalog();
            Console.WriteLine($"\n");

            Invoice invoice = new Invoice();

            Console.WriteLine("Выберите будет ли NDS? 1-Да 2-Нет");
            int NDS;
            NDS = Convert.ToInt32(Console.ReadLine());
            if(NDS == 1)
            {
                invoice.NONDS();
            }
            if (NDS == 2)
            {
                invoice.NDS();
            }

            Console.ReadKey();
        }
    }
}
