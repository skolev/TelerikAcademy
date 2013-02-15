using System;

class GCD
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        do
        {
            if (firstNumber < secondNumber)
            {
                firstNumber += secondNumber;
                secondNumber = firstNumber - secondNumber;
                firstNumber -= secondNumber;
            }
            firstNumber = firstNumber % secondNumber;
        } while ((firstNumber%secondNumber)!=0);
        Console.WriteLine(secondNumber);
    }
}    

