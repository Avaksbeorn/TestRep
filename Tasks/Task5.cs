/*3.����� ���������� ����� ����� ����� ������.*/

namespace ConsoleApp1.Tasks
{
    public static class Task5
    {
        public static void Run() {
            DateTime date1, date2;
            string format = "dd.MM.yyyy";

            Console.WriteLine("������� ������ ���� (� ������� ��.��.����):");
            while (true) {
                if (DateTime.TryParseExact(Console.ReadLine(), format, null, System.Globalization.DateTimeStyles.None, out date1)) {
                    break;
                }
                Console.WriteLine("������������ ����. ����������, ������� ���� � ������� ��.��.����.");
            }

            Console.WriteLine("������� ������ ���� (� ������� ��.��.����):");
            while (true) {
                if (DateTime.TryParseExact(Console.ReadLine(), format, null, System.Globalization.DateTimeStyles.None, out date2)) {
                    break;
                }
                Console.WriteLine("������������ ����. ����������, ������� ���� � ������� ��.��.����.");
            }

            TimeSpan difference = date2 - date1;
            Console.WriteLine($"���������� ����� ����� ������: {Math.Abs(difference.TotalHours)}");
        }
    }
}
