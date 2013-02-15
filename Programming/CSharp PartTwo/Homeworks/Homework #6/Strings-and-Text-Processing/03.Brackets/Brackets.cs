/* Write a program to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d).
 * Example of incorrect expression: )(a+b)).
 */

using System;

class Brackets
{
    static void Main()
    {
        Console.WriteLine("Enter an expression: ");
        string str = Console.ReadLine();
        string restricted = "*/.,+-";
        int counter = 0;
        try
        {
            for (int i = 0; i < str.Length; i++)
            {
                //Checks if the current char is '(' and if the next isn't some of the restricted */.,
                if (str[i] == '(')
                {   
                    counter++;
                    if (restricted.Substring(0, 4).IndexOf(str[i + 1]) > 0)
                    {
                        break;
                    }
                }
                //check if he current char is ')' and if the previous isn't some of the restriced */.,+-
                else if (str[i] == ')' && restricted.IndexOf(str[i - 1]) < 0)
                {
                    counter--;
                }
                if (counter < 0)
                {
                    break;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Correct expression.");
            }
            else
            {
                Console.WriteLine("Incorrect expression.");
            }
        }
        //If the first char in the entered string is ).
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("Incorrect expression.");
        }
    }
}
