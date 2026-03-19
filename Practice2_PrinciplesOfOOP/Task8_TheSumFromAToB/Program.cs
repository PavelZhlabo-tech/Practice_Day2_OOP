namespace Task8_TheSumFromAToB
{
    internal class Program
    {
        //Задание 8
        //11. Даны два целых числа A и B(A < B). Найти сумму всех целых
        //чисел от A до B включительно.
        //Входные данные: ввести два целых числа A, B (1<=A,B<=100).
        //Выходные данные: вывести сумму всех целых чисел от A до B
        //включительно.

        static void Main(string[] args)
        {
            // Задание 8.
            // Найти сумму всех целых чисел от A до B включительно.

            Console.Write("Введите число A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите число B: ");
            int B = int.Parse(Console.ReadLine());

            // Проверка условия A < B
            if (A > B)
            {
                Console.WriteLine("Ошибка: A должно быть меньше или равно B.");
                return;
            }

            int sum = 0;

            // Суммируем числа от A до B
            for (int i = A; i <= B; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Сумма всех целых чисел от {A} до {B} включительно: {sum}");
        }
    }
}
