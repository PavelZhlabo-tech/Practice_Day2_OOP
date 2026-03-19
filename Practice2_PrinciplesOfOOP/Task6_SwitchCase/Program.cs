namespace Task6_SwitchCase
{
    internal class Program
    {
        //Задание 6 Составить программу(при решении данных задач
        //использовать оператор switch или вложенные операторы if).

        //11. Дан номер карты k(6 <=k<= 14), определить достоинство карты.
        //Достоинства определяются по следующему правилу: "туз" - 14, король - 13,
        //дама - 12, валет - 11, десятка - 10, …, шестерка - 6.
        static void Main(string[] args)
        {
            // Задание 6. Определить достоинство карты по её номеру (6–14)

            Console.Write("Введите номер карты k (6–14): ");
            int k = int.Parse(Console.ReadLine());  //номер карты введённый пользователем

            string cardName;

            switch (k)
            {
                case 6:
                    cardName = "шестёрка";
                    break;
                case 7:
                    cardName = "семёрка";
                    break;
                case 8:
                    cardName = "восьмёрка";
                    break;
                case 9:
                    cardName = "девятка";
                    break;
                case 10:
                    cardName = "десятка";
                    break;
                case 11:
                    cardName = "валет";
                    break;
                case 12:
                    cardName = "дама";
                    break;
                case 13:
                    cardName = "король";
                    break;
                case 14:
                    cardName = "туз";
                    break;
                default:
                    Console.WriteLine("Ошибка: номер карты должен быть от 6 до 14.");
                    return;
            }

            Console.WriteLine($"Достоинство карты: {cardName}");
        }
    }
}
