namespace Task2_increasingDigits
{
    internal class Program
    {
        //11. Проверить истинность высказывания: Цифры данного
        //трехзначного числа образуют возрастающую последовательность.
        static void Main(string[] args)
        {
            int number = 357; // любое трёхзначное число

            int hundreds = number / 100;  //вычисляем сотни
            int tens = (number / 10) % 10;  //вычисляем десятки
            int units = number % 10;        //вычисляем единицы

            bool isIncreasing;
            // Проверяем, возрастают ли цифры даннго числа: hundreds < tens < units
            if (hundreds < tens)
            {
                if (tens < units)
                {
                    isIncreasing = true;
                }
                else
                {
                    isIncreasing = false;
                }
            }
            else
            {
                isIncreasing = false;
            }

            Console.WriteLine($"Исходное трёхзначное число: {number}");
            Console.WriteLine($"Образуют ли числа данного числа возрастающую последовательность: {isIncreasing}");
        }
    }
}
