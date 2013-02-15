using System;

class BonusScheme
{
    static void Main()
    {
        Console.Write("Enter a score [1..9]: ");
        int score = int.Parse(Console.ReadLine());

        switch (score)
        {
            case 1:
            case 2:
            case 3:
                score *= 10;
                break;
            case 4:
            case 5:
            case 6:
                score *= 100;
                break;
            case 7:
            case 8:
            case 9:
                score *= 1000;
                break;
            case 0:
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
        Console.WriteLine(score);
    }
}    

