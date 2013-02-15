using System;
using System.Collections.Generic;

class AddTwoNumbers
{
    static List<int> NumberToArray(string enteredNumber)
    {
        //Creating a List with the digits of the entered number.
        List<int> digitList = new List<int>();
        for (int index = 0; index < enteredNumber.Length; index++)
        {
            digitList.Add((enteredNumber[index] - '0'));
        }
        //Reversing the list.
        digitList.Reverse();
        return digitList;
    }
    static void AddsTwoNumbers(List<int> firstList, List<int> secondList)
    {
        //Adds the second list to the first(result).
        for (int i = 0; i < firstList.Count; i++)
        {
            if (i < secondList.Count)
            {
                if ((firstList[i] + secondList[i]) < 10)
                {
                    firstList[i] = firstList[i] + secondList[i];
                }
                else
                {
                    firstList[i] = (firstList[i] + secondList[i]) % 10;
                    if (i + 1 < firstList.Count)
                    {
                        firstList[i + 1]++;
                    }
                    else firstList.Add(1);
                }
            }
            else
            {
                if (firstList[i] >= 10)
                {   
                    firstList[i] %= 10;
                    if (i + 1 < firstList.Count)
                    {
                        firstList[i + 1]++;
                    }
                    else firstList.Add(1);
                }
            }
        }
        firstList.Reverse();
        foreach (var digit in firstList)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter first number: ");
        string num = Console.ReadLine();
        List<int> firstNumberList = NumberToArray(num);
        Console.Write("Enter second number: ");
        num = Console.ReadLine();
        List<int> secondNumberList = NumberToArray(num);

        //First number is bigger
        if (firstNumberList.Count > secondNumberList.Count)
        {
            AddsTwoNumbers(firstNumberList, secondNumberList);
        }
        //Second number is bigger
        else AddsTwoNumbers(secondNumberList, firstNumberList);
    }

}
