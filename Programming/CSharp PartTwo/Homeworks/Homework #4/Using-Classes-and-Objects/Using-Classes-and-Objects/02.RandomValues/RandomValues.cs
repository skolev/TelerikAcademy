using System;

class RandomValues
{
    static void Main()
    {
        Random randomNumber = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomNumber.Next(100, 200));
        }
    }
}