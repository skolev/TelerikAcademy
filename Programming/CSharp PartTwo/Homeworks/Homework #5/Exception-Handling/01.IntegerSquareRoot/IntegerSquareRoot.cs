using System;

class IntegerSquareRoot
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint number = 0;

        try
        {
            number = uint.Parse(Console.ReadLine());
            Console.WriteLine("Square root from {0} is {1:F3}", number, Math.Sqrt(number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}
