using System;

class NumbersComparison
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        float secondNumber = float.Parse(Console.ReadLine());
        Console.WriteLine((firstNumber == secondNumber)? "With precision of 0.000001, the two entered numbers are equal!" :
                                                         "With precision of 0.000001, the two entered numbers aren't equal!");
    }
}   

