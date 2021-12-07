using System;
// Напишисать программу, которая будет выполнять конвертирование валют. 
// Пользователь вводит сумму денег в определенной валюте и 
// курс для конвертации в другую валюту. 
// Необходимо организовать вывод результата операции конвертирования валюты на экран.

namespace Task_2
{
    class Program
    {
        /// <summary>
        /// Конвертирование валюты
        /// </summary>
        /// <param name="currencyAmount">Сумма денег</param>
        /// <param name="currencyCource">Курс для конвертации валюты</param>
        /// <returns>Возвращаемое значение результата конвертации валюты</returns>
        static decimal Currency(decimal currencyAmount, decimal currencyCource)
        {
            return currencyAmount * currencyCource;
        }

        static void Main(string[] args)
        {
            // Инициализация переменных и ввод данных пользователем.
            Console.WriteLine("Введите сумму денег");
            decimal currencyAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите курс валюты для конвертации");
            decimal currencyCource = Convert.ToDecimal(Console.ReadLine());

            // В теле метода Main на 96 строке, вызываем метод Currency,
            // который принимает значения двух переменных и возвращает результат конвертации валюты.
            decimal sumConversion = Currency(currencyAmount, currencyCource);

            // Вывод в консоль результата конвертации валюты.
            Console.WriteLine($"Результат конвертации валюты = {sumConversion}");

            Console.ReadKey();
        }
    }
}
