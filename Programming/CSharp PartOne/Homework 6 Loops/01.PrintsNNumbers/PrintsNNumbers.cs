using System;

class PrintsNNumbers
{
    static void Main()
    {
        Console.Write("Enter a number N: ");
        int n = int.Parse(Console.ReadLine());
        int number = 1;
        do
        {
            Console.WriteLine(number);
            number++;
        } while (number <= n);
    }
}    

