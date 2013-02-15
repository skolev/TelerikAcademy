/*Write a program that downloads a file from Internet
 *(e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
 *and stores it the current directory. Find in
 *Google how to download files in C#. Be sure to
 *catch all exceptions and to free any used resources in the finally block.
 */
using System;
using System.Net;

class FileDownload
{
    static void Main()
    {
        WebClient fileDownload = new WebClient();
        string file = "http://www.devbg.org/img/Logo-BASD.jpg";
        using (fileDownload)
        {
            try
            {
                fileDownload.DownloadFile(file, file.Substring(file.LastIndexOf('/') + 1));
                Console.WriteLine("Download success!");
            }
            catch (WebException we)
            {
                Console.WriteLine(we.Message);
            }
            catch (ArgumentNullException ne)
            {
                Console.WriteLine(ne.Message);
            }

        }
    }
}