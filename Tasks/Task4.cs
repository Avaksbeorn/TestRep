/*6. На трех участках возделывают сельскохозяйственные культуры. Известны виды культур, выращиваемых на каждом из участ-
 * ков. Определить виды тех культур, которые возделывают на каждом из участков; возделывают хотя бы на одном из участков; не
 * возделывают ни на одном участке. (Культуры: картофель, укроп,
 * морковь, горох, капуста, редис.)
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
            string[] kultNames = { "картофель", "укроп", "морковь", "горох", "капуста", "редис" };

            var u1 = GetCulturesFromUser("первого");
            var u2 = GetCulturesFromUser("второго");
            var u3 = GetCulturesFromUser("третьего");

            Console.WriteLine("Культуры, возделываемые на всех участках:");
            foreach (Kult k in Enum.GetValues(typeof(Kult))) {
                if (u1.Contains(k) && u2.Contains(k) && u3.Contains(k)) {
                    Console.Write(kultNames[(int)k] + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Культуры, возделываемые хотя бы на одном участке:");
            foreach (Kult k in Enum.GetValues(typeof(Kult))) {
                if (u1.Contains(k) || u2.Contains(k) || u3.Contains(k)) {
                    Console.Write(kultNames[(int)k] + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Культуры, не возделываемые ни на одном участке:");
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
                { "картофель", Kult.Kartofel },
                { "укроп", Kult.Ukrop },
                { "морковь", Kult.Morkov },
                { "горох", Kult.Goroh },
                { "капуста", Kult.Kapusta },
                { "редис", Kult.Redis }
            };

            var cultures = new HashSet<Kult>();

            Console.WriteLine($"Введите культуры (картофель, укроп, морковь, горох, капуста, редис) для {sectionName} участка (через запятую):");
            string input = Console.ReadLine();
            string[] inputCultures = input.Split(',');

            foreach (var culture in inputCultures) {
                string trimmedCulture = culture.Trim().ToLower();
                if (kultNames.ContainsKey(trimmedCulture)) {
                    cultures.Add(kultNames[trimmedCulture]);
                }
                else {
                    Console.WriteLine($"Культура '{trimmedCulture}' не распознана и будет пропущена.");
                }
            }

            return cultures;
        }
    }
}
