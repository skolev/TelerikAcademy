using System;

class NullValues
{
    static void Main()
    {
        int? firstValue = null;
        Nullable<double> secondValue = null;
        Console.WriteLine(firstValue); //Prints nothing
        Console.WriteLine(firstValue.GetValueOrDefault()); // Prints 0
        Console.WriteLine(secondValue); //Prints nothing
        Console.WriteLine(secondValue.GetValueOrDefault()); // Prints 0
        Console.WriteLine(firstValue + 1); //result is null
        Console.WriteLine(secondValue + 4); //result is null
        firstValue = 7;
        secondValue = 2;
        Console.WriteLine(firstValue);
        Console.WriteLine(secondValue);
    }
}    

