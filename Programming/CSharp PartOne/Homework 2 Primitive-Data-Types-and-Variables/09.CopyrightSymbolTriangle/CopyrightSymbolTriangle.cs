using System;
using System.Text;

class CopyrightSymbolTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        char copySymbol = '©';
        Console.WriteLine("{0,3}",copySymbol);
        Console.WriteLine("{0,2}{0}{0}", copySymbol);
        Console.WriteLine("{0}{0}{0}{0}{0}", copySymbol);
    }
}    
