namespace XslTransform
{
    using System;
    using System.Xml.Xsl;

    public class Program
    {
        public static void Main()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../catalog.xslt");
            xslt.Transform("../../catalog.xml", "../../catalog.html");
        }
    }
}
