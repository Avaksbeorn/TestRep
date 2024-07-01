/*Реализовать структуру данных: 
 * 6.Префиксное дерево
 */
namespace ConsoleApp1.Tasks
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children { get; set; } = new Dictionary<char, TrieNode>();
        public bool IsEndOfWord { get; set; } = false;
    }

    public class Trie
    {
        private readonly TrieNode root;

        public Trie() {
            root = new TrieNode();
        }

        public void Insert(string word) {
            var current = root;
            foreach (var ch in word) {
                if (!current.Children.ContainsKey(ch)) {
                    current.Children[ch] = new TrieNode();
                }
                current = current.Children[ch];
            }
            current.IsEndOfWord = true;
        }

        public bool Search(string word) {
            var current = root;
            foreach (var ch in word) {
                if (!current.Children.ContainsKey(ch)) {
                    return false;
                }
                current = current.Children[ch];
            }
            return current.IsEndOfWord;
        }

        public bool StartsWith(string prefix) {
            var current = root;
            foreach (var ch in prefix) {
                if (!current.Children.ContainsKey(ch)) {
                    return false;
                }
                current = current.Children[ch];
            }
            return true;
        }
    }

    public static class Task6
    {
        public static void Run() {
            var trie = new Trie();

            while (true) {
                Console.WriteLine("1. Вставить слово");
                Console.WriteLine("2. Поиск слова");
                Console.WriteLine("3. Поиск по префиксу");
                Console.WriteLine("0. Выход");

                string choice = Console.ReadLine();

                switch (choice) {
                    case "1":
                        Console.WriteLine("Введите слово для вставки:");
                        string wordToInsert = Console.ReadLine();
                        if (!string.IsNullOrEmpty(wordToInsert)) {
                            trie.Insert(wordToInsert);
                            Console.WriteLine("Слово вставлено.");
                        }
                        else {
                            Console.WriteLine("Некорректный ввод. Слово не может быть пустым.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Введите слово для поиска:");
                        string wordToSearch = Console.ReadLine();
                        if (!string.IsNullOrEmpty(wordToSearch)) {
                            bool found = trie.Search(wordToSearch);
                            Console.WriteLine(found ? "Слово найдено." : "Слово не найдено.");
                        }
                        else {
                            Console.WriteLine("Некорректный ввод. Слово не может быть пустым.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Введите префикс для поиска:");
                        string prefixToSearch = Console.ReadLine();
                        if (!string.IsNullOrEmpty(prefixToSearch)) {
                            bool prefixFound = trie.StartsWith(prefixToSearch);
                            Console.WriteLine(prefixFound ? "Префикс найден." : "Префикс не найден.");
                        }
                        else {
                            Console.WriteLine("Некорректный ввод. Префикс не может быть пустым.");
                        }
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
