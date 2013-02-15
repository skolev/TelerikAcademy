using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        if((n!=0)&&(n<20))
        {
            for (int rows = 1; rows <= n; rows++)
            {
                int number = rows;
                for (int cols = 1; cols <= n; cols++)
                {
                    Console.Write("{0,2} ", number);
                    number++;
                }

                Console.WriteLine();
            }
        }
        else if (n == 0)
        {
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

    }
}    
