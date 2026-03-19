namespace Task1_RectangleGeometry
{
    internal class Program
    {
        //Задание 1 11. Даны стороны прямоугольника. Найти его периметр и
        //длину диагонали.
        static void Main(string[] args)
        {
            double a = 8; // первая сторона прямоугольника
            double b = 10; // вторая сторона прямоугольника

            double perimeter = 2 * (a + b); //считаем диагональ
            double diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)); //считаем диагональ прямоугольника

            Console.WriteLine($"Периметр треугольника = {perimeter}");
            Console.WriteLine($"Диагональ треугольника = {diagonal}");
        }
    }
}
