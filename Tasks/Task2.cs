/*6. ��������� �������� ������� ������: ������� ����� ������
 * �����, ����� � �����, ����� �� ���� 10 ���., �� ������ � 5 ���., �
 * �� ������� � 0,5 ���., ���� �� 100 ���. ���� ������ 100 ����� �����
 */

namespace ConsoleApp1.Tasks
{
    public static class Task2
    {
        public static void Run() {

            for (int bulls = 0; bulls <= 10; bulls++) {
                for (int cows = 0; cows <= 20; cows++) {
                    for (int telenok = 0; telenok <= 200; telenok++) {
                        if (bulls + cows + telenok == 100 && bulls * 10 + cows * 5 + telenok * 0.5 == 100) {
                            Console.WriteLine($"�����: {bulls}, �����: {cows}, ��������: {telenok}");
                        }
                    }
                }
            }
        }
    }
}
