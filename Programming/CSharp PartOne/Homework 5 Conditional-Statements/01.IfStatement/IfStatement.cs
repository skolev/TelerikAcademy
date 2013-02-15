using System;
class IfStatement
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            firstNumber += secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber -= secondNumber;
            Console.WriteLine("First number {0}", firstNumber);
            Console.WriteLine("Second number {0}", secondNumber);
        }
        else 
        {
            Console.WriteLine("First number {0}", firstNumber);
            Console.WriteLine("Second number {0}", secondNumber);
        }
    }
}    
