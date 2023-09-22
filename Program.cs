// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation;
            double number1, number2;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1 - Сложение; 2 - Вычитание; 3 - Умножение; 4 - Деление; 5 - Возведение в степень;");
                Console.WriteLine("6 - Квадратный корень; 7 - 1 процент; 8 - Факториал; 9 - Выход");

                operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Введите первое число: ");
                        number1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        number2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат: " + (number1 + number2));
                        break;
                    case 2:
                        Console.WriteLine("Введите первое число: ");
                        number1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        number2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат: " + (number1 - number2));
                        break;
                    case 3:
                        Console.WriteLine("Введите первое число: ");
                        number1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        number2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат: " + (number1 * number2));
                        break;
                    case 4:
                        Console.WriteLine("Введите первое число: ");
                        number1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        number2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат: " + (number1 / number2));
                        break;
                    case 5:
                        Console.WriteLine("Введите число: ");
                        number1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите степень: ");
                        number2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат: " + Math.Pow(number1, number2));
                        break;
                    case 6:
                        Console.WriteLine("Введите число: ");
                        number1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат: " + Math.Sqrt(number1));
                        break;
                    case 7:
                        Console.WriteLine("Введите число: ");
                        number1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат: " + (number1 / 100));
                        break;
                    case 8:
                        Console.WriteLine("Введите число: ");
                        number1 = double.Parse(Console.ReadLine());
                        double factorial = 1;
                        for (int i = 1; i <= number1; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine("Результат: " + factorial);
                        break;
                    case 9:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор операции. Попробуйте еще раз.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}