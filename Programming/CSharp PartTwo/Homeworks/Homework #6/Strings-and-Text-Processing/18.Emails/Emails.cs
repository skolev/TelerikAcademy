/*Write a program for extracting all email addresses 
 * from given text. All substrings that match the 
 * format <identifier>@<host>…<domain> should be recognized as emails.
 */

using System;
using System.Text.RegularExpressions;

class Emails
{
    static void Main()
    {
        string str = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
        string validMail = @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@[\w*]{2,}.[\w*]{2,}";

        foreach (var mail in Regex.Matches(str, validMail))
        {
            Console.WriteLine(mail);
        }

    }
}
