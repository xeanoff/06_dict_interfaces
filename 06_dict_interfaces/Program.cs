namespace _06_dict
{
    class CountWords
    {
        private Dictionary<string, uint> dict = new Dictionary<string, uint>();

        private char[] delimiters = { ' ', ',', '.', '!', '?', ':' };

        public void Parse(string text)
        {
            dict.Clear();
            string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            foreach (string i in words)
            {
                AddWord(i);
            }
        }

        public void AddWord(string word)
        {
            word = word.ToLower();
            if (dict.ContainsKey(word))
                dict[word] += 1;
            else
                dict.Add(word, 1);
        }
        public void PrintTable()
        {
            Console.WriteLine("Count\t|\tWord");
            Console.WriteLine("\t|\t");
            foreach (var i in dict)
            {
                Console.WriteLine($"{i.Value}\t|\t{i.Key}");
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            string s = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            CountWords cw = new CountWords();
            cw.Parse(s);
            cw.PrintTable();
        }
    }
}