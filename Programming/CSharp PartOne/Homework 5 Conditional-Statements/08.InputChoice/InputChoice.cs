using System;

class InputChoice
{
    static void Main()
    {
        Console.WriteLine("Choose input:\n1.Integer\n2.Double\n3.String");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("Enter variable: ");
        switch (choice)
        {
            //We can use multiple labels for case 1 and case 2, but the int value will be parsed as double.
            case 1:
                int intVariable = int.Parse(Console.ReadLine());
                intVariable++;
                Console.WriteLine(intVariable);
                break;
            case 2:
                double doubleVariable = double.Parse(Console.ReadLine());
                doubleVariable++;
                Console.WriteLine(doubleVariable);
                break;
            case 3:
                string stringVariable = Console.ReadLine();
                stringVariable += "*";
                Console.WriteLine(stringVariable);
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
    }
}    

