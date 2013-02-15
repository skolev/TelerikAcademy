using System;

class NumberToText
{
    static void Main()
    {
        Console.Write("Enter a number from 0 to 999: ");
        string enteredNumber = Console.ReadLine();
        string numberText = string.Empty;
        int[] array = new int[enteredNumber.Length];
        int strPosition = enteredNumber.Length - 1; 
        // s edin for!!!!!!!!
        for (int index = 0; index < enteredNumber.Length; index++)
        {
            string digit = enteredNumber.Substring(strPosition, 1);
            array[index] = int.Parse(digit);
            strPosition--;
            if (index == 0)
            {
                switch (array[index])
                {
                    case 0:
                        numberText = "Zero"; break;
                    case 1:
                        numberText = "One"; break;
                    case 2:
                        numberText = "Two"; break;
                    case 3:
                        numberText = "Three"; break;
                    case 4:
                        numberText = "Four"; break;
                    case 5:
                        numberText = "Five"; break;
                    case 6:
                        numberText = "Six"; break;
                    case 7:
                        numberText = "Seven"; break;
                    case 8:
                        numberText = "Eight"; break;
                    case 9:
                        numberText = "Nine"; break;
                }
            }
            if (index == 1)
            {
                if (array[index] == 1)
                {
                    switch (array[0])
                    {
                        case 0:
                            numberText = "Ten"; break;
                        case 1:
                            numberText = "Eleven"; break;
                        case 2:
                            numberText = "Twelve"; break;
                        case 3:
                            numberText = "Thirteen"; break;
                        case 4:
                            numberText = "Fourteen"; break;
                        case 5:
                            numberText = "Fifteen"; break;
                        case 6:
                            numberText = "Sixteen"; break;
                        case 7:
                            numberText = "Seventeen"; break;
                        case 8:
                            numberText = "Eighteen"; break;
                        case 9:
                            numberText = "Nineteen"; break;
                    }
                }
                else
                {
                    numberText = numberText.ToLower();
                    switch (array[index])
                    {
                        case 2:
                            numberText = "Twenty" + " " + numberText; break;
                        case 3:
                            numberText = "Thirty" + " " + numberText; break;
                        case 4:
                            numberText = "Forty" + " " + numberText; break;
                        case 5:
                            numberText = "Fifty" + " " + numberText; break;
                        case 6:
                            numberText = "Sixty" + " " + numberText; break;
                        case 7:
                            numberText = "Seventy" + " " + numberText; break;
                        case 8:
                            numberText = "Eighty" + " " + numberText; break;
                        case 9:
                            numberText = "Ninety" + " " + numberText; break;
                        case 0:
                            if (enteredNumber.Length == 3)
                            {
                                numberText = "and" + " " + numberText;
                            }
                            else
                            {
                                numberText = "Incorrect input!"; 
                            }
                            break;

                    }
                }
            }
            if (index == 2)
            {
                numberText = numberText.ToLower();
                if ((array[0] == 0) && (array[1] == 0))
                {
                    numberText = "";
                }
                else if (array[1] == 1)
                {
                    numberText = "and" + " " + numberText;
                }
                switch (array[index])
                {

                    case 1:
                        numberText = "One hundred" + " " + numberText; break;
                    case 2:
                        numberText = "Two hundred" + " " + numberText; break;
                    case 3:
                        numberText = "Three hundred" + " " + numberText; break;
                    case 4:
                        numberText = "Four hundred" + " " + numberText; break;
                    case 5:
                        numberText = "Five hundred" + " " + numberText; break;
                    case 6:
                        numberText = "Six hundred" + " " + numberText; break;
                    case 7:
                        numberText = "Seven hundred" + " " + numberText; break;
                    case 8:
                        numberText = "Eight hundred" + " " + numberText; break;
                    case 9:
                        numberText = "Nine hundred" + " " + numberText; break;
                    case 0:
                        numberText = "Incorrect input!"; break;
                }
            }
        }

    Console.WriteLine(numberText);
    }
}    

