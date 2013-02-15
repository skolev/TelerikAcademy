//Data validation is included in every method.
using System;

class ChooseTask
{
    //Reverses digit of a dec number (similar to a previous task)
    static void ReverseNumberDigits()
    {
        Console.Write("Enter a non-negative number: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            while (number != 0)
            {
                Console.Write(number % 10);
                if (number < 0)
                {
                    number = Math.Abs(number);
                }
                number /= 10;
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Entered a negative number!");
        }
    }
    //Calculating average for a set of ints
    static void CalculateAverage()
    {
        Console.Write("Enter a sequence: ");
        string enteredSequence = Console.ReadLine();
        decimal average = 0m;
        if (enteredSequence != string.Empty)
        {
            string[] arr = enteredSequence.Split(' ', ',');
            for (int i = 0; i < arr.Length; i++)
            {
                average += int.Parse(arr[i]);
            }
            average /= arr.Length;
            Console.WriteLine("Sequence average: {0:F3}",average);
        }
        else
        {
            Console.WriteLine("Empty sequence!");
        }


    }
    static void SolveLinearEquation()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        float result = 0f;
        if (a != 0)
        {
            result = (-b) / (float)a;
            Console.WriteLine("x = {0}", result);
        }
        else
        {
            Console.WriteLine("a should not be equal to 0");
        }

    }

    static void Main()
    {
        //Choose which task to do.
        Console.WriteLine("1. Reverses the digits of a number");
        Console.WriteLine("2. Calculates the average of a sequence of integers");
        Console.WriteLine("3. Solves a linear equation a * x + b = 0");
        int choice;
        bool parseSuccess;
        string input;
        do
        {
            Console.Write("Enter choice (1-3): ");
            input = Console.ReadLine();
            parseSuccess = int.TryParse(input, out choice);
            //calling right method
            switch (choice)
            {
                case 1:
                    ReverseNumberDigits(); break;
                case 2:
                    CalculateAverage(); break;
                case 3:
                    SolveLinearEquation(); break;
                default:
                    Console.WriteLine("Invalid choice.");
                    parseSuccess = false;
                    break;
            }
        } while (!parseSuccess);
    }
}

