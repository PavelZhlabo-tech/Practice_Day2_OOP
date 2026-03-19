namespace Task10_AutomorphicNumbers
{
    internal class Program
    {
        //Число называется автоморфным, если оно равно последним числам своего квадарата, yfghbvth 5^2 = 25. Написать программу,
        //находящую все трёхначные автоморфные числа
        static void Main(string[] args)
        {
            Console.WriteLine("Трёхзначные автоморфные числа:");

            for (int n = 100; n <= 999; n++)
            {
                long square = (long)n * n; //(long)n — явное приведение типа, приводим n с int в long      в переменной square, в которой хранится квадрат числа n.

                // Преобразуем в строки для удобного сравнения
                string nStr = n.ToString();             
                string squareStr = square.ToString();     //превращаем число square в строку.

                // Проверяем, заканчивается ли квадрат на само число
                if (squareStr.EndsWith(nStr))
                {
                    Console.WriteLine($"{n} (так как {n}^2 = {square})");   
                }
            }
        }
    }
}
