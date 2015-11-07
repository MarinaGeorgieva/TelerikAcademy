namespace FindSetOfWordsInText
{
    using System;
    using System.IO;
    using System.Linq;

    using Triepocalypse;

    public class Startup
    {
        public static void Main()
        {
            Trie<int> trie = new Trie<int>();

            using (StreamReader reader = new StreamReader("../../test.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(new char[] { ' ', '.', ',', '!', '?', ':', ';', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    foreach (var word in line)
                    {
                        if (!trie.ContainsKey(word))
                        {
                            trie.Add(word, 1);
                        }
                        else
                        {
                            trie[word]++;
                        }
                    }
                }
            }

            trie.Matcher.Next("eros");
            Console.WriteLine(trie.Matcher.GetExactMatch());            
        }
    }
}
