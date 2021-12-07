using System;
// Написать метод, который будет определять: 
// 1) является ли введенное число положительным или отрицательным. 
// 2) Является ли оно простым (используйте технику перебора значений).
// 3) Делится ли на 2, 3, 5, 6, 9 без остатка.

namespace Task_3
{
    class Program
    {
        /// <summary>
        /// Определение является ли число положительным или отрицательным.
        /// </summary>
        /// <param name="argument">Введенное число </param>
        static void Positive(decimal argument)
        {
            if (argument < 0)
            {
                Console.WriteLine($"Введенное число отрицательное");
            }
            else
            {
                Console.WriteLine($"Введенное число положительное");
            }
        }
        /// <summary>
        /// Определение делится ли число на 2, 3, 5, 6, 9 без остатка.
        /// </summary>
        /// <param name="argument">Введенное число</param>
        static void Division(decimal argument)
        {
            if ((argument % 2 == 0) || (argument % 3 == 0) || (argument % 5 == 0) || (argument % 6 == 0) || (argument % 9 == 0))
            {
                Console.WriteLine($"Введенное число делится на один из делителей: 2, 3, 5, 6, 9 без остатка");
            }
            else
            {
                Console.WriteLine($"Введенное число не делится на один из делителей: 2, 3, 5, 6, 9 без остатка");
            }

        }
        /// <summary>
        /// Определение является ли число простым.
        /// </summary>
        /// <param name="argument">Введенное число</param>
        static void Prime(decimal argument)
        {
            bool result = true;
            if (argument > 1)

            {

                for (decimal i = 2; i <= argument / 2; i++)
                {

                    if (argument % i == 0)

                    {
                        result = false;
                        break;
                    }
                }
                if (result)
                {
                    Console.WriteLine($"Введенное число является простым");

                }
                else
                {
                    Console.WriteLine($"Введенное число не является простым");
                }

            }
        }

        static void Main(string[] args)
        {
            // Инициализация переменных и ввод данных пользователем.
            Console.Write("Введите любое число: ");
            decimal argument = Convert.ToInt64(Console.ReadLine());

            // В теле метода Main на 84 строке, вызываем метод Positive,
            // с помощью которого определяем является ли введенное число положительным или отрицательным.
            Positive(argument);

            // В теле метода Main на 88 строке, вызываем метод Division,
            // с помощью которого определяем делится ли введенное число на 2, 3, 5, 6, 9 без остатка.
            Division(argument);

            // В теле метода Main на 92 строке, вызываем метод Prime,
            // с помощью которого определяем является ли введенное число простым.
            Prime(argument);

            Console.ReadKey();
        }
    }
}
