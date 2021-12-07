using System;
// Необходимо создать четыре метода для выполнения арифметических операций, с именами: Add – сложение,
// Sub – вычитание, Mul – умножение, Div – деление.Каждый метод должен принимать два целочисленных 
// аргумента и выводить на экран результат выполнения арифметической операции соответствующей 
// имени метода. Метод деления Div, должен выполнять проверку попытки деления на ноль. 
// Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов и знак 
// арифметической операции, для выполнения вычислений.

namespace Task_1
{
    class Program
    {
        /// <summary>
        /// Сложение двух чисел.
        /// </summary>
        /// <param name="operand1">Первое слогаемое</param>
        /// <param name="operand2">Второе слогаемое</param>
        /// <returns>Сумма двух введенных чисел</returns>

        static double Add(double operand1, double operand2)
        {
            return operand1 + operand2;
        }

        /// <summary>
        /// Вычитание двух чисел.
        /// </summary>
        /// <param name="operand1">Уменьшаемое</param>
        /// <param name="operand2">Вычитаемое</param>
        /// <returns>Разность друх введенынх чисел</returns>
        static double Sub(double operand1, double operand2)
        {
            return operand1 - operand2;
        }

        /// <summary>
        /// Умножение двух чисел.
        /// </summary>
        /// <param name="operand1">Множимое</param>
        /// <param name="operand2">Множитель</param>
        /// <returns>Произведение двух введенных чисел</returns>
        static double Mul(double operand1, double operand2)
        {
            return operand1 * operand2;
        }

        /// <summary>
        /// Деление двух чисел.
        /// </summary>
        /// <param name="operand1">Делимое</param>
        /// <param name="operand2">Делитель</param>
        /// <param name="quotient">Частное двух введенных чисел</param>

        static double Div(double operand1, double operand2)
        {
            // Выполняем проверку деления на ноль.
            if (operand2 == 0)
            {

                Console.WriteLine("Операция невозможна");
                return 0;
            }
            else
            {
                return operand1 / operand2;
            }
        }

        static void Main(string[] args)
        {
            // Инициализация переменных и ввод данных пользователем.
            Console.WriteLine("Введите первое число");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите знак арифметической операции");
            char аrithmeticSign = Convert.ToChar(Console.ReadLine());

            // Для выбора арифметической операции и вивода результатов в консоли 
            // воспользуемся оператором многозначного  выбора switch-case с четырьмя ветвями.
            switch (аrithmeticSign)
            {
                case '+':
                    {
                        // В теле метода Main на 88 строке, вызываем метод Add.
                        Console.WriteLine("{0} + {1} = {2}", operand1, operand2, Add(operand1, operand2));

                        break;
                    }

                case '-':
                    {
                        // В теле метода Main на 96 строке, вызываем метод Sub.
                        Console.WriteLine("{0} - {1} = {2}", operand1, operand2, Sub(operand1, operand2));

                        break;
                    }
                case '*':
                    {
                        // В теле метода Main на 103 строке, вызываем метод Mul. 
                        Console.WriteLine("{0} * {1} = {2}", operand1, operand2, Mul(operand1, operand2));

                        break;

                    }
                case '/':
                    {
                        // В теле метода Main на 111 строке, вызываем метод Div.
                        Console.WriteLine("{0} / {1} = {2}", operand1, operand2, Div(operand1, operand2));

                        break;
                    }

                // Если введення арифметическая операция, или символ который отсутствует в
                // значении операторов case выполняется блок default.
                default:

                    {
                        Console.WriteLine("Вы ввели не верный символ арифметической операции");
                        break;
                    }


            }
            Console.ReadKey();
      
        }
    }
}
