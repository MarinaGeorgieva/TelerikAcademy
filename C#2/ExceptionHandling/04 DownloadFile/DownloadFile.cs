// Problem 4. Download file

// Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
// Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.IO;
using System.Net;

class DownloadFile
{
    static string address = "http://telerikacademy.com/Content/Images/news-img01.png";
    static string fileName = "Ninja.png";

    static void Main(string[] args)
    {
        try
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile(address, fileName);
            Console.WriteLine("Downloaded file saved in the following file system folder: {0}", Directory.GetCurrentDirectory());
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (WebException we)
        {
            Console.WriteLine(we.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}

