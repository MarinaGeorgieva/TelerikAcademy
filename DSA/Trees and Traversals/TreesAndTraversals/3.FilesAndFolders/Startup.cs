namespace _3.FilesAndFolders
{
    using System;
    using System.IO;

    public class Startup
    {
        private const string DirectoryPath = @"C:\Windows";
        private const string FolderName = "Windows";

        public static void Main()
        {
            Folder folder = new Folder(FolderName);
            DirectoryInfo directory = new DirectoryInfo(DirectoryPath);
            TraverseDirectory(directory, folder);

            long size = GetSumOfFileSizes(folder);
            Console.WriteLine("The sum of the file sizes in folder {0} is {1}", folder.Name, size);
        }

        private static long GetSumOfFileSizes(Folder folder)
        {
            long size = 0;

            foreach (var file in folder.Files)
            {
                size += file.Size;
            }

            foreach (var childFolder in folder.ChildFolders)
            {
                GetSumOfFileSizes(childFolder);
            }

            return size;
        }

        private static void TraverseDirectory(DirectoryInfo directory, Folder folder)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirectories = null;

            try
            {
                files = directory.GetFiles();
            }
            catch (UnauthorizedAccessException ex)
            {
                //Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (files != null)
            {
                foreach (var file in files)
                {
                    File newFile = new File(file.Name, file.Length);
                    folder.Files.Add(newFile);
                }

                subDirectories = directory.GetDirectories();

                foreach (var subDirectory in subDirectories)
                {
                    Folder newFolder = new Folder(subDirectory.Name);
                    folder.ChildFolders.Add(newFolder);
                    TraverseDirectory(subDirectory, newFolder);
                }
            }
        }
    }
}
