namespace TraverseDirectoryAndWriteContentsToXmlXDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public class Program
    {
        public static void Main()
        {
            var desktop = Traverse(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            desktop.Save("../../dir.xml");
        }

        private static XElement Traverse(string path)
        {
            var element = new XElement("dir", new XAttribute("path", path));

            foreach (var directory in Directory.GetDirectories(path))
            {
                element.Add(Traverse(directory));
            }

            foreach (var file in Directory.GetFiles(path))
            {
                element.Add(new XElement("file",
                    new XAttribute("name", Path.GetFileNameWithoutExtension(file)),
                    new XAttribute("extension", Path.GetExtension(file))));
            }

            return element;
        }
    }
}
