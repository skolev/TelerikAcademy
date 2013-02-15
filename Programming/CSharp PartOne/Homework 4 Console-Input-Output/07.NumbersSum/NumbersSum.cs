using System;

class NumbersSum
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to sum: ");
        string numbers = Console.ReadLine();
        uint amountNumbers;
        float numbersSum = 0f;
        bool parseSuccess = uint.TryParse(numbers, out amountNumbers);
        if (parseSuccess)
        {
            for (int i = 0; i < amountNumbers; i++)
            {
                Console.Write("Enter number: ");
                numbersSum += float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of the entered number is: {0}", numbersSum);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}    

