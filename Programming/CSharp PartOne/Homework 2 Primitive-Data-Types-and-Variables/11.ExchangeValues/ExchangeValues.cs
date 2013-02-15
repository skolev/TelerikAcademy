using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("First number: {0} Second number: {1}", a, b);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("First number: {0} Second number: {1}", a, b);
    }
}    

