namespace TextFileToXmlDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public class Program
    {
        public static void Main()
        {
            var person = new Person();

            using (StreamReader reader = new StreamReader("../../person.txt"))
            {
                person.Name = reader.ReadLine();
                person.City = reader.ReadLine();
                person.Phone = reader.ReadLine();
            }

            var personXml = new XElement("person",
                new XElement("name", person.Name),
                new XElement("address", person.City),
                new XElement("phone", person.Phone));

            personXml.Save("../../person.xml");
        }
    }
}
