namespace _2.DirectoryTraversal
{
    using System;
    using System.IO;
    using System.Text;

    public class Startup
    {
        private const string Path = @"C:\Windows";

        public static void Main()
        {
            DirectoryInfo directory = new DirectoryInfo(Path);
            StringBuilder result = new StringBuilder();
            TraverseDirectory(directory, result);
            Console.WriteLine(result);
        }

        private static void TraverseDirectory(DirectoryInfo directory, StringBuilder result)
        {
            FileInfo[] exeFiles = null;
            DirectoryInfo[] subDirectories = null;

            try
            {
                exeFiles = directory.GetFiles("*.exe");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (exeFiles != null)
            {
                foreach (var file in exeFiles)
                {
                    result.AppendLine(file.Name);
                }

                subDirectories = directory.GetDirectories();

                foreach (var subDirectory in subDirectories)
                {
                    TraverseDirectory(subDirectory, result);
                }
            }
        }
    }
}
