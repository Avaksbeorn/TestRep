/*6.������� ���������� ����� �� ���������. ���������� ��� ��� ����������� (�� ����� ��� ��� � ����� ������������ ����).*/

namespace ConsoleApp1.Tasks
{
    public static class Task1
    {
        public static void Run() {
            double x, y;

            Console.WriteLine("������� ���������� ����� (x � y):");

            while (true) {
                Console.Write("x: ");
                if (double.TryParse(Console.ReadLine(), out x)) {
                    break;
                }
                Console.WriteLine("������������ ����. ����������, ������� �����.");
            }

            while (true) {
                Console.Write("y: ");
                if (double.TryParse(Console.ReadLine(), out y)) {
                    break;
                }
                Console.WriteLine("������������ ����. ����������, ������� �����.");
            }

            if (x == 0 && y == 0) {
                Console.WriteLine("����� ��������� � ������ ���������.");
            }
            else if (x == 0) {
                Console.WriteLine("����� ��������� �� ��� Y.");
            }
            else if (y == 0) {
                Console.WriteLine("����� ��������� �� ��� X.");
            }
            else if (x > 0 && y > 0) {
                Console.WriteLine("����� ��������� � ������ ��������.");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("����� ��������� �� ������ ��������.");
            }
            else if (x < 0 && y < 0) {
                Console.WriteLine("����� ��������� � ������� ��������.");
            }
            else if (x > 0 && y < 0) {
                Console.WriteLine("����� ��������� � ��������� ��������.");
            }
        }
    }
}
