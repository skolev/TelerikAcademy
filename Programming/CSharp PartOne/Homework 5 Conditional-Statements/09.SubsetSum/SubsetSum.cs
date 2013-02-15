using System;

class SubsetSum
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        int fourthNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        int fifthNumber = int.Parse(Console.ReadLine());
        
        //Subset of 1 number
        if (firstNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0} is zero.", firstNumber);
        }
        if (secondNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0} is zero.", secondNumber);
        }
        if (thirdNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0} is zero.", thirdNumber);
        }
        if (fourthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0} is zero.", fourthNumber);
        }
        if (fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0} is zero.", fifthNumber);
        }

        // Subset of 2 numbers
        if (firstNumber + secondNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1} is zero.", firstNumber, secondNumber);
        }
        if (firstNumber + thirdNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1} is zero.", firstNumber, thirdNumber);
        }
        if (firstNumber + fourthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1} is zero.", firstNumber, fourthNumber);
        }
        if (firstNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1} is zero.", firstNumber, fifthNumber);
        }
        if (secondNumber + thirdNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1} is zero.", secondNumber, thirdNumber);
        }
        if (secondNumber + fourthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1} is zero.", secondNumber, fourthNumber);
        }
        if (secondNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1} is zero.", secondNumber, fifthNumber);
        }
        if (thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1} is zero.", thirdNumber, fourthNumber);
        }
        if (thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1} is zero.", thirdNumber, fifthNumber);
        }
        if (fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1} is zero.", fourthNumber, fifthNumber);
        }
        //Subset of 3 numbers
        if (firstNumber + secondNumber + thirdNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2} is zero.", firstNumber, secondNumber, thirdNumber);
        }
        if (firstNumber + secondNumber + fourthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2} is zero.", firstNumber, secondNumber, fourthNumber);
        }
        if (firstNumber + secondNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2} is zero.", firstNumber, secondNumber, fifthNumber);
        }
        if (firstNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2} is zero.", firstNumber, thirdNumber, fourthNumber);
        }
        if (firstNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2} is zero.", firstNumber, thirdNumber, fifthNumber);
        }
        if (firstNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2} is zero.", firstNumber, fourthNumber, fifthNumber);
        }
        if (secondNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2} is zero.", secondNumber, thirdNumber, fourthNumber);
        }
        if (secondNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2} is zero.", secondNumber, thirdNumber, fifthNumber);
        }
        if (secondNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2} is zero.", secondNumber, fourthNumber, fifthNumber);
        }
        if (thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2} is zero.", thirdNumber, fourthNumber, fifthNumber);
        }
        // Subset of 4 numbers
        if (firstNumber + secondNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2}, {3} is zero.", firstNumber, secondNumber, thirdNumber, fourthNumber);
        }
        if (firstNumber + secondNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2}, {3} is zero.", firstNumber, secondNumber, thirdNumber, fifthNumber);
        }
        if (firstNumber + secondNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2}, {3} is zero.", firstNumber, secondNumber, fourthNumber, fifthNumber);
        }
        if (firstNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2}, {3} is zero.", firstNumber, thirdNumber, fourthNumber, fifthNumber);
        }
        if (secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2}, {3} is zero.", secondNumber, thirdNumber, fourthNumber, fifthNumber);
        }
        //Subset of 5 numbers
        if (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of the subset: {0}, {1}, {2}, {3}, {4} is zero.", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
        }
    }
}    

