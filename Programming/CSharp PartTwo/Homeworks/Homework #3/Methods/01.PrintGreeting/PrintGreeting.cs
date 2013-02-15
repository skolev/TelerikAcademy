using System;

class PrintGreeting
{
    static void GetNamePrintGreeting()
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine("Hello, {0}!",userName);
    }
    static void Main()
    {
        GetNamePrintGreeting();
    }

}
