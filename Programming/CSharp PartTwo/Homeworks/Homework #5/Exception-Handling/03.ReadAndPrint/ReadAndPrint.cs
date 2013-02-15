/*Write a program that enters file name along with its
 * full file path (e.g. C:\WINDOWS\win.ini), reads its 
 * contents and prints it on the console. Find in MSDN 
 * how to use System.IO.File.ReadAllText(…). Be sure 
 * to catch all possible exceptions and print user-friendly 
 * error messages.
 */
using System;
using System.IO;
using System.Security;

class ReadAndPrint
{
    static void Main()
    {
        string path = Console.ReadLine();
        try
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (PathTooLongException pe)
        {
            Console.WriteLine(pe.Message);
        }
        catch (DirectoryNotFoundException de)
        {
            Console.WriteLine(de.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException ue)
        {
            Console.WriteLine(ue.Message);
        }
        catch (NotSupportedException ns)
        {
            Console.WriteLine(ns.Message);
        }
        catch (SecurityException se)
        {
            Console.WriteLine(se.Message);
        }
    }
}

