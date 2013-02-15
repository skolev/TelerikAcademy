using System;
using System.Collections.Generic;

class CalcFactorial
{
    static List<int> CalculateFactorial(List<int> factorial, int number)
    {
        //Uses following algorithm: 5 x 24 = 10 x (5x20) + 1 x (5x4) 
        int counter = 1;
        int carry = 0;
        while (counter <= number)
        {
            for (int index = 0; index < factorial.Count; index++)
            {
                factorial[index] *= counter;
                factorial[index] += carry;
                if ((factorial[index] > 10) && ((index + 1) == factorial.Count))
                {
                    factorial.Add(factorial[index] / 10);
                    factorial[index] %= 10;

                    //Checks if the last added element is bigger 10.
                    //Avoid overload for the last element and for int carry.
                    if (factorial[index + 1] > 10)
                    {
                        factorial.Add(factorial[index+1] / 10);
                        factorial[index + 1] %= 10;
                    }
                    break;
                }
                else
                {
                    carry = factorial[index] / 10;
                    factorial[index] %= 10;
                }
            }
            carry = 0;
            counter++;
        }
        factorial.Reverse();
        return factorial;
    }
    static void Main()
    {
        Console.Write("Enter a number [1 - 100]: ");
        int enteredNumber = int.Parse(Console.ReadLine());
        List<int> factorial = new List<int>();
        factorial.Add(1);
        factorial = CalculateFactorial(factorial, enteredNumber);
        foreach (var digit in factorial)
        {
            Console.Write(digit);
        }
        Console.WriteLine();

    }
}

