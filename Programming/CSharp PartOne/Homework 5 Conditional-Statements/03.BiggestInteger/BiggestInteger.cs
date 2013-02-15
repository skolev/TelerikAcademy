using System;

class BiggestInteger
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("Biggest number is: {0}", firstNumber);
            }
            else
            {
                Console.WriteLine("Biggest number is: {0}", thirdNumber);
            }
        }
        else if (secondNumber > thirdNumber)
        {
            Console.WriteLine("Biggest number is: {0}", secondNumber);
        }
        else
        {
            Console.WriteLine("Biggest number is: {0}", thirdNumber);
        }
    }
}    

