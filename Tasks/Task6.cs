/*����������� ��������� ������: 
 * 6.���������� ������
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
                Console.WriteLine("1. �������� �����");
                Console.WriteLine("2. ����� �����");
                Console.WriteLine("3. ����� �� ��������");
                Console.WriteLine("0. �����");

                string choice = Console.ReadLine();

                switch (choice) {
                    case "1":
                        Console.WriteLine("������� ����� ��� �������:");
                        string wordToInsert = Console.ReadLine();
                        if (!string.IsNullOrEmpty(wordToInsert)) {
                            trie.Insert(wordToInsert);
                            Console.WriteLine("����� ���������.");
                        }
                        else {
                            Console.WriteLine("������������ ����. ����� �� ����� ���� ������.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("������� ����� ��� ������:");
                        string wordToSearch = Console.ReadLine();
                        if (!string.IsNullOrEmpty(wordToSearch)) {
                            bool found = trie.Search(wordToSearch);
                            Console.WriteLine(found ? "����� �������." : "����� �� �������.");
                        }
                        else {
                            Console.WriteLine("������������ ����. ����� �� ����� ���� ������.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("������� ������� ��� ������:");
                        string prefixToSearch = Console.ReadLine();
                        if (!string.IsNullOrEmpty(prefixToSearch)) {
                            bool prefixFound = trie.StartsWith(prefixToSearch);
                            Console.WriteLine(prefixFound ? "������� ������." : "������� �� ������.");
                        }
                        else {
                            Console.WriteLine("������������ ����. ������� �� ����� ���� ������.");
                        }
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("�������� �����. ���������� �����.");
                        break;
                }
            }
        }
    }
}
