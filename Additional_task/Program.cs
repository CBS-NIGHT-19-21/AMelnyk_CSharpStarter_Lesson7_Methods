using System;
// Создайть метод с именем Calculate, который принимает в качестве параметров три целочисленных 
// аргумента и выводит на экран среднее арифметическое значение аргументов. 

namespace Additional_task
{
    class Program
    {
        /// <summary>
        /// Расчет среднего арифметического значения введеных целочисленных чисел.
        /// </summary>
        /// <param name="argument1">Первое введенное число</param>
        /// <param name="argument2">Второе введенное число</param>
        /// <param name="argument3">Третье введенное число</param>
        static void Calculate(double argument1, double argument2, double argument3)
        {

            Console.WriteLine($"Среднеарифметическое значение введенных чисел " +
                $"= {(argument1 + argument2 + argument3) / 3}");
        }

        static void Main(string[] args)
        {
            // Инициализация переменных и ввод данных пользователем.
            Console.WriteLine("Введите три целочисленных числа");

            double argument1 = Convert.ToInt64(Console.ReadLine());

            double argument2 = Convert.ToInt64(Console.ReadLine());

            double argument3 = Convert.ToInt64(Console.ReadLine());

            // В теле метода Main на 35 строке, вызываем метод Calculate,
            // который принимает значения трех введенных чисел.
            Calculate(argument1, argument2, argument3);

            Console.ReadKey();
        }
    }
}
