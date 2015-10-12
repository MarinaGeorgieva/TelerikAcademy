namespace AllSongsTitlesXmlReader
{
    using System;
    using System.Xml;

    public class Program
    {
        public static void Main()
        {
            using (XmlReader reader = XmlReader.Create("../../catalog.xml") )
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadElementContentAsString());
                    }
                }
            }
        }
    }
}
