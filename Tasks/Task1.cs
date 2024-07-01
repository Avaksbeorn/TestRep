/*6.Введите координаты точки на плоскости. Определите где она расположена (на какой оси или в каком координатном углу).*/

namespace ConsoleApp1.Tasks
{
    public static class Task1
    {
        public static void Run() {
            double x, y;

            Console.WriteLine("Введите координаты точки (x и y):");

            while (true) {
                Console.Write("x: ");
                if (double.TryParse(Console.ReadLine(), out x)) {
                    break;
                }
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }

            while (true) {
                Console.Write("y: ");
                if (double.TryParse(Console.ReadLine(), out y)) {
                    break;
                }
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }

            if (x == 0 && y == 0) {
                Console.WriteLine("Точка находится в начале координат.");
            }
            else if (x == 0) {
                Console.WriteLine("Точка находится на оси Y.");
            }
            else if (y == 0) {
                Console.WriteLine("Точка находится на оси X.");
            }
            else if (x > 0 && y > 0) {
                Console.WriteLine("Точка находится в первой четверти.");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("Точка находится во второй четверти.");
            }
            else if (x < 0 && y < 0) {
                Console.WriteLine("Точка находится в третьей четверти.");
            }
            else if (x > 0 && y < 0) {
                Console.WriteLine("Точка находится в четвертой четверти.");
            }
        }
    }
}
