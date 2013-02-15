using System;

class TenMembersSequence
{
    static void Main()
    {
        int a = 2;
        int b = -3;
        Console.Write("The first 10 members of the sequence: ");
        for (int i = 2; i <= 10; i += 2)
        {
            Console.Write("{0},{1}", a, b);
            if (i == 10)
                break;
            a = a + 2;
            b = b + (-2);
            Console.Write(",");
        }
        Console.WriteLine(".");
    }
}

