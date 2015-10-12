namespace ExtractAlbumsFromFiveYearsAgoLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class Program
    {
        public static void Main()
        {
            var doc = XDocument.Load("../../catalog.xml");
            var albums =
                from album in doc.Descendants("album")
                where int.Parse(album.Element("year").Value) < 2010
                select new
                {
                    Name = album.Element("name").Value,
                    Price = album.Element("price").Value
                };

            foreach (var album in albums)
            {
                Console.WriteLine("{0} --> {1}$", album.Name, album.Price);
            }
        }
    }
}
