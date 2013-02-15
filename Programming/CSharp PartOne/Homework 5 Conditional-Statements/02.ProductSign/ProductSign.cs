using System;

class ProductSign
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            float thirdNumber = float.Parse(Console.ReadLine());
            int i = 0;
            if (firstNumber < 0)
            {
                i++;
            }
            if (secondNumber < 0)
            {
                i++;
            }
            if (thirdNumber < 0)
            {
                i++;
            }
            if ((i == 1) || (i == 3))
            {
                Console.WriteLine("Product sign is \"-\"");
            }
            else
            {
                Console.WriteLine("Product sign is \"+\"");
            }
        }
    }

