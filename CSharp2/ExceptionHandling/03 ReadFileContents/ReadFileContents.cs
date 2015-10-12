// Problem 3. Read file contents

// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
// reads its contents and prints it on the console.

using System;
using System.IO;

class ReadFileContents
{
    static void Main(string[] args)
    {
        Console.Write("Enter file name with its full file path: ");
        string path = Console.ReadLine();

        try
        {
            Console.WriteLine(File.ReadAllText(path));
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (PathTooLongException ptle)
        {
            Console.WriteLine(ptle.Message);
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine(dnfe.Message);
        }
        catch (FileLoadException fle)
        {
            Console.WriteLine(fle.Message);
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine(fnfe.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }        
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }  
    }
}

