﻿/*Реализовать структуру данных: 
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

        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            var current = root;
            foreach (var ch in word)
            {
                if (!current.Children.ContainsKey(ch))
                {
                    current.Children[ch] = new TrieNode();
                }
                current = current.Children[ch];
            }
            current.IsEndOfWord = true;
        }

        public bool Search(string word)
        {
            var current = root;
            foreach (var ch in word)
            {
                if (!current.Children.ContainsKey(ch))
                {
                    return false;
                }
                current = current.Children[ch];
            }
            return current.IsEndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            var current = root;
            foreach (var ch in prefix)
            {
                if (!current.Children.ContainsKey(ch))
                {
                    return false;
                }
                current = current.Children[ch];
            }
            return true;
        }

        public bool Delete(string word)
        {
            return Delete(root, word, 0);
        }

        public bool Delete(TrieNode current, string word, int index)
        {
            if (index == word.Length)
            {
                if (!current.IsEndOfWord)
                {
                    return false; // Елси слово не найдено
                }
                current.IsEndOfWord = false; // Помечаем конец слова как не существующий

                // Если у текущего узла нет детей, можно удалить этот узел
                return current.Children.Count == 0;
            }

            char ch = word[index];
            if (!current.Children.ContainsKey(ch))
            {
                return false;
            }

            bool shouldDeleteCurrentNode = Delete(current.Children[ch], word, index + 1);

            if (shouldDeleteCurrentNode)
            {
                // Удаляем ссылку на дочерний узел
                current.Children.Remove(ch);

                // Возвращаем true, если после удаления текущий узел не является концом другого слова и у него нет других детей
                return current.Children.Count == 0 && !current.IsEndOfWord;
            }

            return false;
        }
    }

    public static class Task6
    {
        public static void Run()
        {
            var trie = new Trie();

            while (true)
            {
                Console.WriteLine("1. Вставить слово");
                Console.WriteLine("2. Поиск слова");
                Console.WriteLine("3. Поиск по префиксу");
                Console.WriteLine("4. Удалить слово");
                Console.WriteLine("0. Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Введите слово для вставки:");
                        string wordToInsert = Console.ReadLine();
                        if (!string.IsNullOrEmpty(wordToInsert))
                        {
                            trie.Insert(wordToInsert);
                            Console.WriteLine("Слово вставлено.");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Слово не может быть пустым.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Введите слово для поиска:");
                        string wordToSearch = Console.ReadLine();
                        if (!string.IsNullOrEmpty(wordToSearch))
                        {
                            bool found = trie.Search(wordToSearch);
                            Console.WriteLine(found ? "Слово найдено." : "Слово не найдено.");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Слово не может быть пустым.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Введите префикс для поиска:");
                        string prefixToSearch = Console.ReadLine();
                        if (!string.IsNullOrEmpty(prefixToSearch))
                        {
                            bool prefixFound = trie.StartsWith(prefixToSearch);
                            Console.WriteLine(prefixFound ? "Префикс найден." : "Префикс не найден.");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Префикс не может быть пустым.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Введите слово для удаления:");
                        string wordToDelete = Console.ReadLine();
                        if (!string.IsNullOrEmpty(wordToDelete))
                        {
                            bool deleted = trie.Delete(wordToDelete);
                            Console.WriteLine(deleted ? "Слово удалено." : "Слово не найдено (или удалено, но явлется частью другого слова).");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Слово не может быть пустым.");
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
