internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите координату X: ");
        double x;
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Некорректный ввод. Введите координату X: ");
        }

        Console.Write("Введите координату Y: ");
        double y;
        while (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.Write("Некорректный ввод. Введите координату Y: ");
        }

        if (x > 0 && y > 0)
        {
            System.Console.WriteLine("Точка находится в первом координатном углу.");
        }
        else if (x < 0 && y > 0)
        {
            System.Console.WriteLine("Точка находится во втором координатном углу.");
        }
        else if (x < 0 && y < 0)
        {
            System.Console.WriteLine("Точка находится в третьем координатном углу.");
        }
        else if (x > 0 && y < 0)
        {
            System.Console.WriteLine("Точка находится в четвертом координатном углу.");
        }
        else if (x == 0 && y != 0)
        {
            System.Console.WriteLine("Точка находится на оси Y.");
        }
        else if (y == 0 && x != 0)
        {
            System.Console.WriteLine("Точка находится на оси X.");
        }
        else
        {
            System.Console.WriteLine("Точка находится в начале координат.");
        }
    }
}