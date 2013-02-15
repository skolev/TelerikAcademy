/*Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
 *If an invalid number or non-number text is entered, the method should throw an exception.
 *Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */
using System;

class EnterTenNumbers
{
    static int ReadNumber(int start, int end)
    {
        int number = 0;
        try
        {
            number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Entered number it's not in range!");
            return 0;
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
            return 0;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
            return 0;
        }
        return number;
        



    }
    static void Main()
    {
        int num = 1;
        Console.WriteLine("Enter ten numbers from 1 to 100 (each on a new line)");
        for (int i = 0; i < 10; i++)
        {
            num = ReadNumber(num, 100);
            if (num == 0)
            {
                break;
            }
        }
    }
}
