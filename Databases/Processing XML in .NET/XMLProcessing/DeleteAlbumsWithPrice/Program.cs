namespace DeleteAlbumsWithPrice
{
    using System;
    using System.Xml;

    public class Program
    {
        public static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../catalog.xml");
            var root = doc.DocumentElement;

            DeleteAlbumsWithPrice(root);
            doc.Save("../../newCatalog.xml");
        }

        private static void DeleteAlbumsWithPrice(XmlElement root)
        {
            foreach (XmlElement album in root.SelectNodes("album"))
            {
                string xmlPrice = album["price"].InnerText;
                double price = double.Parse(xmlPrice);

                if (price > 20)
                {
                    root.RemoveChild(album);
                }
            }
        }
    }
}
