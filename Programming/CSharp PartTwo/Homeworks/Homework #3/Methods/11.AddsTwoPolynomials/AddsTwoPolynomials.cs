using System;

class AddsTwoPolynomials
{
    // Creates array of coef.
    static int[] CreateArrayOfCoefficients(int[] arr)
    {
        for (int index = arr.Length - 1; index >= 0; index--)
        {
            Console.Write("Enter coef. for x^{0}: ",index);
            arr[index] = int.Parse(Console.ReadLine());
        }
        return arr;
    }
    //Caclulates new coef for the new polynomial in the second array (equal or bigger than first one)
    static void AddsPolynomials(int[] firstArr, int[] secondArr)
    {
        for (int index = 0; index < firstArr.Length; index++)
        {
            secondArr[index] += firstArr[index];
        }
    //Prints new coef.
        for (int i = secondArr.Length -1 ; i >= 0; i--)
        {
            Console.WriteLine("Coef. for x^{0}: {1}", i, secondArr[i]);
        }
    }
    static void Main()
    {
        //Input polynomial degree and coef.
        Console.Write("Enter first polynomial degree: ");
        int firstDegree = int.Parse(Console.ReadLine());
        int[] firstPolynomial = new int[firstDegree+1];
        firstPolynomial = CreateArrayOfCoefficients(firstPolynomial);
        Console.Write("Enter second polynomial degree: ");
        int secondDegree = int.Parse(Console.ReadLine());
        int[] secondPolynomial = new int[secondDegree+1];
        secondPolynomial = CreateArrayOfCoefficients(secondPolynomial);
        if (firstDegree < secondDegree)
        {
            AddsPolynomials(firstPolynomial, secondPolynomial);
        }
        else
        {
            AddsPolynomials(secondPolynomial, firstPolynomial);
        }
    }
}
