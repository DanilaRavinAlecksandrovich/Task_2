using System;
using System.Collections.Generic;
using System.Text;

namespace Danila_2.Echo
{
    class Invoice
    {
        public readonly int account = 1;
        public readonly string customer = "Я";
        public readonly string provider = "Я";
        private string article;
        private int quantity;


        

        public void NDS()
        {
            article = "Машина";
            quantity = 180;

           

            Console.WriteLine($"Аккаунт: {account}");
            Console.WriteLine($"Покупатель: {customer}");
            Console.WriteLine($"Услуга: {provider}");
            Console.WriteLine($"Предмет: {article}");
            Console.WriteLine($"Цена: {quantity}");
        }

        public void NONDS()
        {
            article = "Машина";
            quantity = 180;

            quantity = quantity+(quantity * 10 / 100);

            Console.WriteLine($"Аккаунт: {account}");
            Console.WriteLine($"Покупатель: {customer}");
            Console.WriteLine($"Услуга: {provider}");
            Console.WriteLine($"Предмет: {article}");
            Console.WriteLine($"Цена: {quantity}");
        }
    }
}
