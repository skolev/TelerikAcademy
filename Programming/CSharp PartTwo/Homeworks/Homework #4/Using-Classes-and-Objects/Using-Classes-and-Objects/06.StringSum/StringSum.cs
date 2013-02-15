using System;

class StringSum
{
    static int CalculateStringSum(string str)
    {
        int stringSum = 0;
        string[] numbers = str.Split(' ');
        foreach (var num in numbers)
        {
            stringSum += int.Parse(num);
        }
        return stringSum;
    }
    static void Main()
    {
        string str = "43 68 9 23 318";
        Console.WriteLine(CalculateStringSum(str));
    }
}
