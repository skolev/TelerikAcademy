using System;

class WithoutRemainder
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int NumberToCheck = int.Parse(Console.ReadLine());
        bool check = (NumberToCheck % 7 == 0) && (NumberToCheck % 5 == 0); ;
        Console.WriteLine((check)? "The number divides by 7 and 5 at the same time." : 
                                   "The number can't be divided by 7 and 5 at the same time.");
    }
}    

