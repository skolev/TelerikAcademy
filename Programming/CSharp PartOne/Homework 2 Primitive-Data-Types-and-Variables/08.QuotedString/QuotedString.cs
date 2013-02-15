using System;

class QuotedString
{
    static void Main()
    {
        string quoteOne = "The \"use\" of quotations causes difficulties.";
        string quoteTwo = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quoteOne);
        Console.WriteLine(quoteTwo);
    }
}   

