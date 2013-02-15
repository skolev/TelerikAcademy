//Extending previous task
using System;

class OperationsWithPolynomials
{
    static int[] CreateArrayOfCoefficients(int[] arr)
    {
        for (int index = arr.Length - 1; index >= 0; index--)
        {
            Console.Write("Enter coef. for x^{0}: ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }
        return arr;
    }
    static void AddsPolynomials(int[] firstArr, int[] secondArr)
    {

        for (int index = 0; index < firstArr.Length; index++)
        {
            secondArr[index] += firstArr[index];
        }
        for (int i = secondArr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("Coef. for x^{0}: {1}", i, secondArr[i]);
        }
    }
    static void SubstractPolynomials(int[] firstArr, int[] secondArr)
    {
        for (int index = 0; index < firstArr.Length; index++)
        {
            secondArr[index] -= firstArr[index];
        }
        for (int i = secondArr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("Coef. for x^{0}: {1}", i, secondArr[i]);
        }
    }
    static void MultiplicatePolynomials(int[] firstArr, int[] secondArr)
    {
        int[] resultArray = new int[firstArr.Length + secondArr.Length - 1];
        for (int index = 0; index < firstArr.Length; index++)
        {
            for (int i = 0; i < secondArr.Length; i++)
            {
                resultArray[i+index] += secondArr[i] * firstArr[index];
            }   
        }
        for (int i = resultArray.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("Coef. for x^{0}: {1}", i, resultArray[i]);
        }
    }
    static void Main()
    {
        Console.Write("Enter first polynomial degree: ");
        int firstDegree = int.Parse(Console.ReadLine());
        int[] firstPolynomial = new int[firstDegree + 1];
        firstPolynomial = CreateArrayOfCoefficients(firstPolynomial);
        Console.Write("Enter second polynomial degree: ");
        int secondDegree = int.Parse(Console.ReadLine());
        int[] secondPolynomial = new int[secondDegree + 1];
        secondPolynomial = CreateArrayOfCoefficients(secondPolynomial);
        Console.WriteLine("1. Adds two polynomials.");
        Console.WriteLine("2. Subtract two polynomials");
        Console.WriteLine("3. Multiplicate two polynomials");
        Console.Write("Enter choice (1-3): ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {

            case 1:
                if (firstDegree < secondDegree)
                {
                    AddsPolynomials(firstPolynomial, secondPolynomial);
                }
                else
                {
                    AddsPolynomials(secondPolynomial, firstPolynomial);
                }
                break;
            case 2:
                if (firstDegree < secondDegree)
                {
                    SubstractPolynomials(firstPolynomial, secondPolynomial);
                }
                else
                {
                    SubstractPolynomials(secondPolynomial, firstPolynomial);
                }
                break;
            case 3:
                if (firstDegree < secondDegree)
                {
                    MultiplicatePolynomials(firstPolynomial, secondPolynomial);
                }
                else
                {
                    MultiplicatePolynomials(secondPolynomial, firstPolynomial);
                }
                break;
            default:
                Console.WriteLine("Not a valid choice.");
                break;


        }
    }
}    

