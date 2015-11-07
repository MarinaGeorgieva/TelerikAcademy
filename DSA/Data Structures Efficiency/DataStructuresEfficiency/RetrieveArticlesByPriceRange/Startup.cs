namespace RetrieveArticlesByPriceRange
{
    using System;
    using System.Collections.Generic;

    using Wintellect.PowerCollections;

    public class Startup
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const int ArticlesCount = 10000;
        private const int BarcodeLength = 13;
        private const int VendorLength = 6;
        private const int TitleLength = 10;

        private static readonly Random random = new Random();

        public static void Main()
        {
            var dictionary = new OrderedMultiDictionary<decimal, Article>(true);

            GenerateArticles(dictionary);
            FindArticlesByPriceRange(dictionary);
        }

        private static void FindArticlesByPriceRange(OrderedMultiDictionary<decimal, Article> dictionary)
        {
            decimal fromPrice = 250;
            decimal toPrice = 275;
            var articles = dictionary.Range(fromPrice, true, toPrice, true);

            Console.WriteLine("Price range: [{0}, {1}]", fromPrice, toPrice);
            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }

        private static void GenerateArticles(OrderedMultiDictionary<decimal, Article> dictionary)
        {
            var barcodes = new HashSet<string>();
            while (barcodes.Count < ArticlesCount)
            {
                string barcode = GetRandomString(BarcodeLength);
                barcodes.Add(barcode);
            }

            foreach (var barcode in barcodes)
            {
                string vendor = GetRandomString(VendorLength);
                string title = GetRandomString(TitleLength);
                decimal price = GetRandomNumber(100, 1000);
                Article article = new Article(barcode, vendor, title, price);
                dictionary.Add(price, article);
            }
        }

        private static int GetRandomNumber(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        private static string GetRandomString(int length)
        {
            char[] chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = Alphabet[random.Next(0, Alphabet.Length)];
            }

            return new string(chars);
        }
    }
}
