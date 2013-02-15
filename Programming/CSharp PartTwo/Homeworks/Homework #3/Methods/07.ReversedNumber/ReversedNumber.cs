using System;

class ReversedNumber
{
    static void ReverseDigits(int number)
    {
        while (number!=0)
        {
            Console.Write(number%10);
            if (number < 0)
            {
               number = Math.Abs(number);
            }
            number /= 10;
        }
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        int enteredNumber = int.Parse(Console.ReadLine());
        ReverseDigits(enteredNumber);
        Console.WriteLine();
    }

}
