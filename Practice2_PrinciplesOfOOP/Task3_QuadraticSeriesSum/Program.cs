namespace Task3_QuadraticSeriesSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11. Дано целое число N (N > 0). Найти сумму:
            // N^2 + (N + 1)^2 + (N + 2)^2 + … + (2·N)^2.
            // Входные данные: ввести целое число N (1 <= N <= 10).
            // Выходные данные: вывести сумму квадратов от N^2 до (2N)^2.

            Console.Write("Введите N (1 <= N <= 10): ");
            int N = int.Parse(Console.ReadLine());

            //создаем переменную для сохраенния суммы квадратов
            double sum = 0;

            for (int i = N; i <= 2 * N; i++)
            {
                sum += i*i;
            }

            Console.WriteLine("Сумма квадратов от N^2 до (2N)^2 = " + sum);
        }
    }
}
