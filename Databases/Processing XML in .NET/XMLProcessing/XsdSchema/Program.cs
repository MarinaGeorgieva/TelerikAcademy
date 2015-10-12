namespace XsdSchema
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    public class Program
    {
        public static void Main()
        {
            var schema = new XmlSchemaSet();
            schema.Add(string.Empty, "../../catalog.xsd");

            XDocument doc = XDocument.Load("../../catalog.xml");
            XDocument otherDoc = XDocument.Load("../../otherCatalog.xml");

            ValidateSchema(doc, schema, "catalog.xml");
            ValidateSchema(otherDoc, schema, "otherCatalog.xml");
        }

        private static void ValidateSchema(XDocument doc, XmlSchemaSet schema, string file)
        {
            doc.Validate(schema, (obj, ev) =>
            {
                Console.WriteLine("{0} --> {1}", file, ev.Message);
            });
        }
    }
}
