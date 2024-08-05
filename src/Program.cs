using ConsoleApp1.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("Выберите задачу для выполнения:");
                Console.WriteLine("1. Определение координат точки");
                Console.WriteLine("2. Покупка скота");
                Console.WriteLine("3. Проверка номеров автобусов");
                Console.WriteLine("4. Сельскохозяйственные культуры");
                Console.WriteLine("5. Количество часов между датами");
                Console.WriteLine("6. Префиксное дерево");
                Console.WriteLine("0. Выход");

                string choice = Console.ReadLine();

                switch (choice) {
                    case "1":
                        Task1.Run();
                        break;
                    case "2":
                        Task2.Run();
                        break;
                    case "3":
                        Task3.Run();
                        break;
                    case "4":
                        Task4.Run();
                        break;
                    case "5":
                        Task5.Run();
                        break;
                    case "6":
                        Task6.Run();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}
