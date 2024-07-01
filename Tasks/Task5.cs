/*3.Найти количество часов между двумя датами.*/

namespace ConsoleApp1.Tasks
{
    public static class Task5
    {
        public static void Run() {
            DateTime date1, date2;
            string format = "dd.MM.yyyy";

            Console.WriteLine("Введите первую дату (в формате ДД.ММ.ГГГГ):");
            while (true) {
                if (DateTime.TryParseExact(Console.ReadLine(), format, null, System.Globalization.DateTimeStyles.None, out date1)) {
                    break;
                }
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите дату в формате ДД.ММ.ГГГГ.");
            }

            Console.WriteLine("Введите вторую дату (в формате ДД.ММ.ГГГГ):");
            while (true) {
                if (DateTime.TryParseExact(Console.ReadLine(), format, null, System.Globalization.DateTimeStyles.None, out date2)) {
                    break;
                }
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите дату в формате ДД.ММ.ГГГГ.");
            }

            TimeSpan difference = date2 - date1;
            Console.WriteLine($"Количество часов между датами: {Math.Abs(difference.TotalHours)}");
        }
    }
}
