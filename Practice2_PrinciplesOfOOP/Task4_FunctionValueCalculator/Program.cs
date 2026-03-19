using System;

namespace Task4_FunctionValueCalculator
{
    class Program
    {
        static void Main()
        {
            //Задание 4.Написать программу, которая вычисляет значение функции
            //у:
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            //переменная для хранения значения функции
            double y;

            // Проверяем, в какой диапазон попадает x
            if (x > 1 && x < 2)
            {
                // Считаем первую часть функции: (x - 2)^2 + 6 если x > 1 && x < 2
                y = Math.Pow(x - 2, 2) + 6;
            }
            else if (x >= 2)
            {
                // Вторая часть функции: ln(x + 3√x)
                double yPart2 = x + 3 * Math.Sqrt(x);

                if (yPart2 <= 0)
                {
                    Console.WriteLine("Ошибка: выражение под логарифмом должно быть > 0.");
                    return;
                }

                y = Math.Log(yPart2);
            }
            else
            {
                Console.WriteLine("Значение x не попадает ни в один диапазон функции.");
                return;
            }

            Console.WriteLine($"Найденное значение y: = {y}");
        }
    }
}

