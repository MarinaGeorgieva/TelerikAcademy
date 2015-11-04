namespace _3.CountWordOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        private const string WordsFilePath = "../../words.txt";

        public static void Main()
        {
            string text = File.ReadAllText(WordsFilePath);
            string[] words = text.Split(new char[] { ',', '.', '!', '?', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            int index = 0;
            while (index < words.Length)
            {
                string word = words[index].ToLower();
                if (!wordsCount.ContainsKey(word.ToLower()))
                {
                    wordsCount.Add(word, 1);
                }
                else
                {
                    wordsCount[word]++;
                }

                index++;
            }

            var wordsCountOrderedByValue = wordsCount.OrderBy(p => p.Value);
            foreach (var pair in wordsCountOrderedByValue)
            {
                Console.WriteLine("{0} --> {1}", pair.Key, pair.Value);
            }
        }
    }
}
