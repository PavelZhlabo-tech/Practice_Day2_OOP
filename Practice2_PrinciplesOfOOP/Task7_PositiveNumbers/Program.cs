namespace Task7_PositiveNumbers
{
    internal class Program
    {
        //Задание 7 Вывести на экран(задачу решите тремя способами -
        //используя операторы цикла while, do while и for) :

        //11. только положительные целые числа из диапазона от А до В);
        static void Main(string[] args)
        {
            Console.Write("Введите число а: ");

            int a = Convert.ToInt32(Console.ReadLine());
            
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Решаем задачу с использованием цикла while");
            int i = a;

            while (i<=b)
            {
                if (i > 0)
                {
                    Console.WriteLine("Положтельное число: " + i);
                }
                
            }

            Console.WriteLine("Решаем задачу с использованием do while");

            i = a;
            do
            {
                if (i > 0)
                {
                    Console.WriteLine("Положительное число: " + i);
                }
            }
            while (i <= b);

            Console.WriteLine("Решаем задачу с использованием цикла for: ");
            for (int j = a; i<= b; i++)
            {
                Console.WriteLine("Положительное число: " + j);
            }
        }
    }
}
