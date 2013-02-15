using System;

class LetterByLetter
{
    static void Main()
    {
        bool arrayCompare = true;
        Console.WriteLine("Enter first array (as string): ");
        string firstString = Console.ReadLine();
        char[] firstArray = firstString.ToCharArray();
        Console.WriteLine("Enter second array (as string): ");
        string secondString = Console.ReadLine();
        char[] secondArray = secondString.ToCharArray();
        if (firstArray.Length == secondArray.Length)
        {
            for (int index = 0; index < firstArray.Length; index++)
            {
                if (firstArray[index] != secondArray[index])
                {
                    arrayCompare = false;
                    break;
                }
            }
        }
        else
        {
            arrayCompare = false;
        }
        Console.WriteLine("Two arrays are equal? {0}", arrayCompare);
    }
}    

