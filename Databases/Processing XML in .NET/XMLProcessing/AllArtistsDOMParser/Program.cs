namespace AllArtistsDOMParser
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class Program
    {
        public static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../catalog.xml");
            var root = doc.DocumentElement;

            foreach (var pair in ExtractAllArtists(root))
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
        }

        private static Dictionary<string, int> ExtractAllArtists(XmlElement root)
        {
            var result = new Dictionary<string, int>();
            var artists = root.GetElementsByTagName("artist");

            foreach (XmlElement artist in artists)
            {
                var artistName = artist.InnerText;

                if (result.ContainsKey(artistName))
                {
                    result[artistName] += 1;
                }
                else
                {
                    result.Add(artistName, 1);
                }
            }

            return result;
        }
    }
}
