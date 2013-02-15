using System;

class BiggestOfThree
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber >= secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
 
    }

    static void Main()
    {
        //Entering three numbers.
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        //Calling method GetMax()
        int biggestNumber = GetMax((GetMax(firstNumber, secondNumber)),thirdNumber);
        //Print the biggest number
        Console.WriteLine("Biggest number is: {0}",biggestNumber);
    }

}
