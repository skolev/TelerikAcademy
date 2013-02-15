using System;

class SortRealValues
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        float secondNumber = float.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        float thirdNumber = float.Parse(Console.ReadLine());

        if (thirdNumber > secondNumber)
        {
            thirdNumber += secondNumber;
            secondNumber = thirdNumber - secondNumber;
            thirdNumber -= secondNumber;

            if (secondNumber > firstNumber)
            {
                secondNumber += firstNumber;
                firstNumber = secondNumber - firstNumber;
                secondNumber -= firstNumber;

                if (secondNumber < thirdNumber)
                {
                    thirdNumber += secondNumber;
                    secondNumber = thirdNumber - secondNumber;
                    thirdNumber -= secondNumber;
                }
            }
        }
        else if (secondNumber > firstNumber)
        {
            secondNumber += firstNumber;
            firstNumber = secondNumber - firstNumber;
            secondNumber -= firstNumber;

            if (secondNumber < thirdNumber)
            {
                thirdNumber += secondNumber;
                secondNumber = thirdNumber - secondNumber;
                thirdNumber -= secondNumber;
            }

            
        }
        Console.WriteLine("{0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
    }
}    

