using System;
using System.Text;

class ASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int i;
        int min = 0;
        int max = 255; // For extended ASCII table: int max = 255;
        Console.Write("Decimal".PadRight(10));
        Console.WriteLine("ASCII".PadRight(10));
        for (i = min; i <= max; i++)
        {
            char symbol = (char)i;
            string displaySymbol;
            if (i <= 31)
            {
                displaySymbol = "Control Symbol";
            }
            else
            {
                switch (i)
                {
                    case 32:
                        displaySymbol = "space";
                        break;
                    case 127:
                        displaySymbol = "del";
                        break;
                    default:
                        displaySymbol = symbol.ToString();
                        break;
                }

            }
            Console.Write(i.ToString().PadRight(10));
            Console.WriteLine(displaySymbol);
        }
    }
}    

