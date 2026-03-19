using System;

    namespace Task9_FunctionTabulation
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //Задание 9 Табулирование функций.
                //Постановка задачи: Составить программу вычисления значений
                //функции F(x) на отрезке[A, B] в точках x i = x + H, где H = (B - A) / M, M – заданное
                //целое число.
                //Пример: Получить 20 значений функции F(x) при изменении
                //аргумента x в диапазоне[0, 1; 2,1] с шагом 0,1.
                // Вариант 11: F(x) = sin(1/x)
                // A = π/8, B = 2/π, M = 15

                double A = Math.PI / 8;   //считаем A по условии
                double B = 2.0 / Math.PI; //считаем B по условии
                int M = 15; //считаем M по условии

                // Шаг табулирования
                double H = (B - A) / M;

                Console.WriteLine($"A = {A}");
                Console.WriteLine($"B = {B}");
                Console.WriteLine($"M = {M}");
                Console.WriteLine($"H = {H}\n");

                double x = A;

                Console.WriteLine("Таблица значений F(x) = sin(1/x):\n");

                for (int i = 1; i <= M; i++)
                {
                    double y = Math.Sin(1 / x);

                    Console.WriteLine($"i = {i}, x = {x:F6}, F(x) = {y:F6}");

                    x += H;
                }
            }
        }
    }


