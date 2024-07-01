/*6. �� ���� �������� ����������� �������������������� ��������. �������� ���� �������, ������������ �� ������ �� �����-
 * ���. ���������� ���� ��� �������, ������� ����������� �� ������ �� ��������; ����������� ���� �� �� ����� �� ��������; ��
 * ����������� �� �� ����� �������. (��������: ���������, �����,
 * �������, �����, �������, �����.)
 */

namespace ConsoleApp1.Tasks
{
    public static class Task4
    {
        enum Kult
        {
            Kartofel,
            Ukrop,
            Morkov,
            Goroh,
            Kapusta,
            Redis
        }

        public static void Run() {
            string[] kultNames = { "���������", "�����", "�������", "�����", "�������", "�����" };

            var u1 = GetCulturesFromUser("�������");
            var u2 = GetCulturesFromUser("�������");
            var u3 = GetCulturesFromUser("��������");

            Console.WriteLine("��������, ������������� �� ���� ��������:");
            foreach (Kult k in Enum.GetValues(typeof(Kult))) {
                if (u1.Contains(k) && u2.Contains(k) && u3.Contains(k)) {
                    Console.Write(kultNames[(int)k] + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("��������, ������������� ���� �� �� ����� �������:");
            foreach (Kult k in Enum.GetValues(typeof(Kult))) {
                if (u1.Contains(k) || u2.Contains(k) || u3.Contains(k)) {
                    Console.Write(kultNames[(int)k] + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("��������, �� ������������� �� �� ����� �������:");
            foreach (Kult k in Enum.GetValues(typeof(Kult))) {
                if (!u1.Contains(k) && !u2.Contains(k) && !u3.Contains(k)) {
                    Console.Write(kultNames[(int)k] + " ");
                }
            }
            Console.WriteLine();
        }

        private static HashSet<Kult> GetCulturesFromUser(string sectionName)
        {
            var kultNames = new Dictionary<string, Kult> {
                { "���������", Kult.Kartofel },
                { "�����", Kult.Ukrop },
                { "�������", Kult.Morkov },
                { "�����", Kult.Goroh },
                { "�������", Kult.Kapusta },
                { "�����", Kult.Redis }
            };

            var cultures = new HashSet<Kult>();

            Console.WriteLine($"������� �������� (���������, �����, �������, �����, �������, �����) ��� {sectionName} ������� (����� �������):");
            string input = Console.ReadLine();
            string[] inputCultures = input.Split(',');

            foreach (var culture in inputCultures) {
                string trimmedCulture = culture.Trim().ToLower();
                if (kultNames.ContainsKey(trimmedCulture)) {
                    cultures.Add(kultNames[trimmedCulture]);
                }
                else {
                    Console.WriteLine($"�������� '{trimmedCulture}' �� ���������� � ����� ���������.");
                }
            }

            return cultures;
        }
    }
}
