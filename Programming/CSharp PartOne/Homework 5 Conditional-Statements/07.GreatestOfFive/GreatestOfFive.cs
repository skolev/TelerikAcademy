using System;

class GreatestOfFive
{
    static void Main()
    {
        float greatestNumber = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter a number: ");
            float someNumber = float.Parse(Console.ReadLine());
            greatestNumber = Math.Max(greatestNumber, someNumber);
        }
        Console.WriteLine("Greatest of entered numbers is: {0}", greatestNumber);
    }
}    

