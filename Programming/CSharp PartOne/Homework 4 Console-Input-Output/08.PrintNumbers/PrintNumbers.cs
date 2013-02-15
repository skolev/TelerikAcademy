using System;

class PrintNumbers
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int highestNumber = int.Parse(Console.ReadLine());
        for (int i = 1; i <= highestNumber; i++)
        {
            Console.WriteLine(i);
        }
    }
}    

