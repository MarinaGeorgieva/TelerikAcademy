namespace AllSongsTitlesXDocument
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class Program
    {
        public static void Main()
        {
            var doc = XDocument.Load("../../catalog.xml");
            var songs =
                from song in doc.Descendants("song")
                select new
                {
                    Title = song.Element("title").Value
                };

            foreach (var song in songs)
            {
                Console.WriteLine(song.Title);
            }
        }
    }
}
