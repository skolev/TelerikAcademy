using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int primeNumber = int.Parse(Console.ReadLine());
        bool check = (primeNumber % 2 != 0) && (primeNumber % 3 != 0) && (primeNumber % 5 != 0) && (primeNumber % 7 != 0);
        Console.WriteLine((check) ?
            "Prime number!" : "Not a prime number!");
    }
}    

