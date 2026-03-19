namespace Task5_IsoscelesTriangle
{
    internal class Program
    {
        //Задание 5. Написать программу, которая определяет:
        //11. является ли треугольник с длинами сторон a, b, c равнобедренным.
        static void Main(string[] args)
        {

            Console.Write("Введите сторону a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите сторону b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите сторону c: ");
            double c = double.Parse(Console.ReadLine());

            // Проверяем существование треугольника
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Треугольник с такими сторонами не существует."); //если не соответствует условию
                return;
            }

            // Проверяем равнобедренность: две стороны должны быть равны
            bool isIsosceles = (a == b) || (a == c) || (b == c);

            if (isIsosceles)
            {
                Console.WriteLine("Треугольник является равнобедренным.");
            }
            else
            {
                Console.WriteLine("Треугольник не является равнобедренным.");
            }
        }
    }
}
