/*Write a program that reads a text file containing 
 * a list of strings, sorts them and saves them to another text file.
 */
using System;
using System.Collections.Generic;
using System.IO;

class SortsStrings
{
    static void Main()
    {
        //Getting the names from file in a List of strings
        List<string> names = new List<string>();
        StreamReader reader = new StreamReader(@"..\..\names.txt");

        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                names.Add(line);
                line = reader.ReadLine();
            }
        }
        //Sorts the list.
        names.Sort();
        //Write the list into a file.
        StreamWriter writer = new StreamWriter(@"..\..\sorted.names.txt", false);

        using (writer)
        {
            foreach (var name in names)
            {
                writer.WriteLine(name);
            }
        }
    }
}
