namespace ExtractAlbumsFromFiveYearsAgoXPath
{
    using System;
    using System.Xml;

    public class Program
    {
        public static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            var albums = doc.SelectNodes("/catalog/album[year]");
            foreach (XmlNode album in albums)
            {
                var year = int.Parse(album.SelectSingleNode("year").InnerText);
                if (year < 2010)
                {
                    var albumName = album.SelectSingleNode("name").InnerText;
                    var albumPrice = album.SelectSingleNode("price").InnerText;
                    Console.WriteLine("{0} --> {1}$", albumName, albumPrice);
                }
            }
        }
    }
}
