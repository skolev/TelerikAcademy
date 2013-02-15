using System;

class ThreeNumbersSum
{
    static void Main()
    {
        Console.WriteLine("Enter three integer numbers");
        string inputNumber;
        int number = 0;
        long sum = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Number: ");
            inputNumber = Console.ReadLine();
            bool parseSuccess = Int32.TryParse(inputNumber, out number);
            if (parseSuccess)
            {
                sum += number;
            }
            else
            {
                Console.WriteLine("Invalid number!");
                break;
            }
        }
        Console.WriteLine("Sum: {0}", sum);
    }
}
