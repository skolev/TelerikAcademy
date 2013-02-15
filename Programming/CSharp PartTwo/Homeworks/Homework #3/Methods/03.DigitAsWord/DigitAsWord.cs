using System;

class DigitAsWord
{
    static string ConvertDigitToWord(int enteredNumber)
    {
        // Getting last digit
        int digit = enteredNumber%10;
        //Return last digit as word
        switch (digit)
        {
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: return "zero";

             


        }
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        int enteredNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(ConvertDigitToWord(enteredNumber));
    }

}
